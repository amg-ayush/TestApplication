using TestApplication.BussinesObjects;

namespace TestApplication.Response
{
    /// <summary>
    /// Данные о пациенте
    /// </summary>
    public class PatientResponse
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

        /// <summary>
        /// Данные об участке
        /// </summary>
        public RegionResponse Region { get; set; }
    }
}
