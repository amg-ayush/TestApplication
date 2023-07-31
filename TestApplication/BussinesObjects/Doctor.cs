namespace TestApplication.BussinesObjects
{
    /// <summary>
    /// Врач
    /// </summary>
    public class Doctor : BaseObject
    {
        /// <summary>
        /// ФИО врача
        /// </summary>
        public string? FIO { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        public Office Office { get; set; }

        /// <summary>
        /// Специализация
        /// </summary>
        public Specialization Specialization { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        public Region? Region { get; set; }
    }
}
