namespace TestApplication.Response
{
    /// <summary>
    /// Базовые данные о враче
    /// </summary>
    public class DoctorResponseBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ФИО врача
        /// </summary>
        public string? FIO { get; set; }
    }

    /// <summary>
    /// Данные о враче для детального представления
    /// </summary>
    public class DoctorResponseDetail : DoctorResponseBase
    {
        /// <summary>
        /// Идентификатор кабинета
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Идентификатор специализации
        /// </summary>
        public int SpecializationId { get; set; }

        /// <summary>
        /// Идентификатор участка
        /// </summary>
        public int? RegionId { get; set; }
    }

    /// <summary>
    /// Данные о враче для списочного представления
    /// </summary>
    public class DoctorResponseList : DoctorResponseBase
    {
        /// <summary>
        /// Номер кабинета
        /// </summary>
        public int OfficeNum { get; set; }

        /// <summary>
        /// Название специализации
        /// </summary>
        public string SpecializationName { get; set; }

        /// <summary>
        /// Номер участка
        /// </summary>
        public int? RegionNum { get; set; }
    }
}
