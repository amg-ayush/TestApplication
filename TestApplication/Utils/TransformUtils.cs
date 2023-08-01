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
        /// Возвращает данные о пациенте для детального представления
        /// </summary>
        /// <param name="patient">Пациент</param>
        public static PatientResponseDetail Get(this Patient patient)
        {
            return new PatientResponseDetail()
            {
                Id = patient.Id,
                LastName = patient.LastName,
                FirstName = patient.FirstName,
                MiddleName = patient.MiddleName,
                Address = patient.Address,
                BirthDate = patient.BirthDate,
                Gender = patient.Gender,
                RegionId = patient.Region != null ? patient.Region.Id : 0,
            };
        }

        /// <summary>
        /// Возвращает данные о пациенте для списочного представления
        /// </summary>
        /// <param name="patient">Пациент</param>
        public static PatientResponseList GetForList(this Patient patient)
        {
            return new PatientResponseList()
            {
                Id = patient.Id,
                LastName = patient.LastName,
                FirstName = patient.FirstName,
                MiddleName = patient.MiddleName,
                Address = patient.Address,
                BirthDate = patient.BirthDate,
                Gender = patient.Gender,
                RegionNum = patient.Region != null ? patient.Region.Num : 0,
            };
        }

        /// <summary>
        /// Возвращает данные о враче для детального представления
        /// </summary>
        /// <param name="doctor">Врач</param>
        public static DoctorResponseDetail Get(this Doctor doctor)
        {
            return new DoctorResponseDetail()
            {
                Id = doctor.Id,
                FIO = doctor.FIO,
                OfficeId = doctor.Office != null ? doctor.Office.Id : 0,
                SpecializationId = doctor.Specialization != null ? doctor.Specialization.Id : 0,
                RegionId = doctor.Region != null ? doctor.Region.Id : null,
            };
        }

        /// <summary>
        /// Возвращает данные о враче для списочного представления
        /// </summary>
        /// <param name="doctor">Врач</param>
        public static DoctorResponseList GetForList(this Doctor doctor)
        {
            return new DoctorResponseList()
            {
                Id = doctor.Id,
                FIO = doctor.FIO,
                OfficeNum = doctor.Office != null ? doctor.Office.Num : 0,
                SpecializationName = doctor.Specialization?.Name,
                RegionNum = doctor.Region != null ? doctor.Region.Num : null,
            };
        }
    }
}
