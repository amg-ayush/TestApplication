using System.ComponentModel.DataAnnotations;

namespace TestApplication.Requests
{
    /// <summary>
    /// Запрос врач
    /// </summary>
    public class DoctorRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ФИО врача
        /// </summary>
        [Required]
        public string? FIO { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        [Required]
        public int OfficeId { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        [Required]
        public int SpecializationId { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public int RegionId { get; set; }
    }
}
