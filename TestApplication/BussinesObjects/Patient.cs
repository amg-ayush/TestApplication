namespace TestApplication.BussinesObjects
{
    /// <summary>
    /// Пациент
    /// </summary>
    public class Patient : BaseObject
    {
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
        /// Участок
        /// </summary>
        public virtual Region Region { get; set; }
    }

    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        Male = 0,

        /// <summary>
        /// Женский
        /// </summary>
        Female = 1,
    }
}
