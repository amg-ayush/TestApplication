using Microsoft.AspNetCore.Mvc;
using TestApplication.BussinesObjects;
using TestApplication.Requests;
using TestApplication.Response;
using TestApplication.Utils;

namespace TestApplication.Controllers
{
    /// <summary>
    /// Контроллер пациентов
    /// </summary>
    public class PatientController : Controller
    {
        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="request">Данные пациента</param>
        [HttpPost(nameof(Create))]
        public PatientResponse Create(PatientRequest request)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Patient newPatient = new Patient();
                newPatient.LastName = request.LastName;
                newPatient.FirstName = request.FirstName;
                newPatient.MiddleName = request.MiddleName;
                newPatient.Address = request.Address;
                newPatient.BirthDate = request.BirthDate;
                newPatient.Gender = request.Gender;
                newPatient.Region = db.Regions.GetObject(request.RegionId);
                db.Patients.Add(newPatient);
                db.SaveChanges();
                return newPatient.Get();
            }
        }

        /// <summary>
        /// Удаление пациента
        /// </summary>
        /// <param name="id">Идентификатор пациента</param>
        [HttpDelete(nameof(Delete))]
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Patient deletePatient = db.Patients.GetObject(id);
                db.Patients.Remove(deletePatient);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Обновление данных о пациенте
        /// </summary>
        /// <param name="request">Данные пациента</param>
        [HttpPut(nameof(Update))]
        public PatientResponse Update(PatientRequest request)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Patient updPatient = db.Patients.GetObject(request.Id);
                updPatient.LastName = request.LastName;
                updPatient.FirstName = request.FirstName;
                updPatient.MiddleName = request.MiddleName;
                updPatient.Address = request.Address;
                updPatient.BirthDate = request.BirthDate;
                updPatient.Gender = request.Gender;
                updPatient.Region = db.Regions.GetObject(request.RegionId);
                db.SaveChanges();
                return updPatient.Get();
            }
        }

        /// <summary>
        /// Получает данные о пациенте
        /// </summary>
        /// <param name="id">Идентификатор пациента</param>
        [HttpGet(nameof(Get))]
        public PatientResponse Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Patient patient = db.Patients.GetObject(id);
                db.LoadProperties(patient, nameof(Patient.Region));
                return patient.Get();
            }
        }
    }
}