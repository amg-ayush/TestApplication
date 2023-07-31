using TestApplication.BussinesObjects;
using TestApplication.Response;

namespace TestApplication.Utils
{
    /// <summary>
    /// Вспомогательный класс для преобразования объектов хранимых классов в данные сервиса
    /// </summary>
    public static class TransformUtils
    {
        /// <summary>
        /// Возвращает данные о пациенте
        /// </summary>
        /// <param name="patient">Пациент</param>
        public static PatientResponse Get(this Patient patient)
        {
            return new PatientResponse()
            {
                Id = patient.Id,
                LastName = patient.LastName,
                FirstName = patient.FirstName,
                MiddleName = patient.MiddleName,
                Address = patient.Address,
                BirthDate = patient.BirthDate,
                Gender = patient.Gender,
                Region = patient.Region.Get(),
            };
        }

        /// <summary>
        /// Возвращает данные о враче
        /// </summary>
        /// <param name="doctor">Врач</param>
        public static DoctorResponse Get(this Doctor doctor)
        {
            return new DoctorResponse()
            {
                Id = doctor.Id,
                FIO = doctor.FIO,
                Office = doctor.Office.Get(),
                Specialization = doctor.Specialization.Get(),
                Region = doctor.Region?.Get(),
            };
        }

        /// <summary>
        /// Возвращает данные об участке
        /// </summary>
        /// <param name="region">Участок</param>
        public static RegionResponse Get(this Region region)
        {
            return new RegionResponse()
            {
                Id = region.Id,
                Num = region.Num,
            };
        }

        /// <summary>
        /// Возвращает данные о кабинете
        /// </summary>
        /// <param name="office">Кабинет</param>
        public static OfficeResponse Get(this Office office)
        {
            return new OfficeResponse()
            {
                Id = office.Id,
                Num = office.Num,
            };
        }

        /// <summary>
        /// Возвращает данные о специализации
        /// </summary>
        /// <param name="specialization">Специализация</param>
        public static SpecializationResponse Get(this Specialization specialization)
        {
            return new SpecializationResponse()
            {
                Id = specialization.Id,
                Name = specialization.Name,
            };
        }
    }
}
