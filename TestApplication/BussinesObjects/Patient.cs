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

        /// <summary>
        /// Возвращает свойство для сортировки
        /// </summary>
        /// <param name="property">Указанное свойство</param>
        public static Func<Patient, object> GetOrderProperty(int property)
        {
            PatientProperty patientProperty = (PatientProperty)property;
            switch (patientProperty)
            {
                case PatientProperty.Id:
                    return d => d.Id;
                case PatientProperty.LastName:
                    return d => d.LastName;
                case PatientProperty.FirstName:
                    return d => d.FirstName;
                case PatientProperty.MiddleName:
                    return d => d.MiddleName;
                case PatientProperty.Address:
                    return d => d.Address;
                case PatientProperty.BirthDate:
                    return d => d.BirthDate;
                case PatientProperty.Gender:
                    return d => d.Gender;
                default:
                    return d => d.Id;
            }
        }
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

    /// <summary>
    /// Свойства объекта пациента
    /// </summary>
    public enum PatientProperty
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Id = 1,

        /// <summary>
        /// Фамилия пациента
        /// </summary>
        LastName = 2,

        /// <summary>
        /// Имя пациента
        /// </summary>
        FirstName = 3,

        /// <summary>
        /// Отчество пациента
        /// </summary>
        MiddleName = 4,

        /// <summary>
        /// Адрес
        /// </summary>
        Address = 5,
        
        /// <summary>
        /// Дата рождения
        /// </summary>
        BirthDate = 6,

        /// <summary>
        /// Пол
        /// </summary>
        Gender = 7,

        /// <summary>
        /// Участок
        /// </summary>
        Region = 8,
    }
}
