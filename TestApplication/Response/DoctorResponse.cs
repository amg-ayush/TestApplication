namespace TestApplication.Response
{
    /// <summary>
    /// Данные о враче
    /// </summary>
    public class DoctorResponse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ФИО врача
        /// </summary>
        public string? FIO { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        public OfficeResponse Office { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        public SpecializationResponse Specialization { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public RegionResponse? Region { get; set; }
    }
}
