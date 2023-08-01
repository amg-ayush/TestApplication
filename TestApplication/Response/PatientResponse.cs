using TestApplication.BussinesObjects;

namespace TestApplication.Response
{
    /// <summary>
    /// Базовые данные о пациенте
    /// </summary>
    public class PatientResponseBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия пациента
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Имя пациента
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Отчество пациента
        /// </summary>
        public string? MiddleName { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }
    }

    /// <summary>
    /// Данные о пациенте для детального представления
    /// </summary>
    public class PatientResponseDetail : PatientResponseBase
    {
        /// <summary>
        /// Идентификатор участка
        /// </summary>
        public int RegionId { get; set; }
    }

    /// <summary>
    /// Данные о пациенте для списочного представления
    /// </summary>
    public class PatientResponseList : PatientResponseBase
    {
        /// <summary>
        /// Номер участка
        /// </summary>
        public int RegionNum { get; set; }
    }
}
