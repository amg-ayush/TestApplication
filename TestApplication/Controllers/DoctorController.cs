using Microsoft.AspNetCore.Mvc;
using TestApplication.BussinesObjects;
using TestApplication.Requests;
using TestApplication.Response;
using TestApplication.Utils;

namespace TestApplication.Controllers
{
    /// <summary>
    /// Контроллер врачей
    /// </summary>
    public class DoctorController : Controller
    {
        /// <summary>
        /// Создание врача
        /// </summary>
        /// <param name="request">Данные о враче</param>
        [HttpPost(nameof(Create))]
        public DoctorResponseDetail Create(DoctorRequest request)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Doctor newDoctor = new Doctor();
                newDoctor.FIO = request.FIO;
                newDoctor.Office = db.Offices.GetObject(request.OfficeId);
                newDoctor.Specialization = db.Specializations.GetObject(request.SpecializationId);
                newDoctor.Region = db.Regions.GetObject(request.RegionId, true);
                db.Doctors.Add(newDoctor);
                db.SaveChanges();
                return newDoctor.Get();
            }
        }

        /// <summary>
        /// Удаление врача
        /// </summary>
        /// <param name="id">Идентификатор врача</param>
        [HttpDelete(nameof(Delete))]
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Doctor deleteDoctor = db.Doctors.GetObject(id);
                db.Doctors.Remove(deleteDoctor);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Обновление данных о враче
        /// </summary>
        /// <param name="request">Данные о враче</param>
        [HttpPut(nameof(Update))]
        public DoctorResponseDetail Update(DoctorRequest request)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Doctor updDoctor = db.Doctors.GetObject(request.Id);
                updDoctor.FIO = request.FIO;
                updDoctor.Office = db.Offices.GetObject(request.OfficeId);
                updDoctor.Specialization = db.Specializations.GetObject(request.SpecializationId);
                updDoctor.Region = db.Regions.GetObject(request.RegionId, true);
                db.SaveChanges();
                return updDoctor.Get();
            }
        }

        /// <summary>
        /// Получает данные о враче
        /// </summary>
        /// <param name="id">Идентификатор врача</param>
        [HttpGet(nameof(Get))]
        public DoctorResponseDetail Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Doctor doctor = db.Doctors.GetObject(id);
                db.LoadProperties(doctor, nameof(Doctor.Office), nameof(Doctor.Specialization), nameof(Doctor.Region));
                return doctor.Get();
            }
        }

        /// <summary>
        /// Получает список данных о пациентах
        /// </summary>
        /// <param name="pageNum">Номер страницы</param>
        /// <param name="sortProperty">Сортировка по заданному свойству</param>
        [HttpGet(nameof(GetList))]
        public IEnumerable<DoctorResponseList> GetList(int pageNum, int sortProperty)
        {
            CheckPageNum(pageNum);
            CheckProperty<DoctorProperty>(sortProperty);

            int skipCount = takeCount * (pageNum - 1);

            using (ApplicationContext db = new ApplicationContext())
            {
                List<DoctorResponseList> list = new List<DoctorResponseList>();
                foreach (Doctor doctor in db.Doctors
                    .GetLoadedList(nameof(Doctor.Office), nameof(Doctor.Specialization), nameof(Doctor.Region))
                    .OrderBy(Doctor.GetOrderProperty(sortProperty))
                    .Skip(skipCount)
                    .Take(takeCount))
                    list.Add(doctor.GetForList());

                return list;
            }
        }
    }
}