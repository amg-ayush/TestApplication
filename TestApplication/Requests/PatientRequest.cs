using System.ComponentModel.DataAnnotations;
using TestApplication.BussinesObjects;

namespace TestApplication.Requests
{
    /// <summary>
    /// Запрос пациент
    /// </summary>
    public class PatientRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия пациента
        /// </summary>
        [Required]
        public string? LastName { get; set; }

        /// <summary>
        /// Имя пациента
        /// </summary>
        [Required]
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
        [Required]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Идентификатор участка
        /// </summary>
        [Required]
        public int RegionId { get; set; }
    }
}
