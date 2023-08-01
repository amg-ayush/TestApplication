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

        /// <summary>
        /// Возвращает свойство для сортировки
        /// </summary>
        /// <param name="property">Указанное свойство</param>
        public static Func<Doctor, object> GetOrderProperty(int property)
        {
            DoctorProperty doctorProperty = (DoctorProperty)property;

            switch (doctorProperty)
            {
                case DoctorProperty.Id:
                    return d => d.Id;
                case DoctorProperty.FIO:
                    return d => d.FIO;
                case DoctorProperty.Office:
                    return d => d.Office?.Num;
                case DoctorProperty.Specialization:
                    return d => d.Specialization.Name;
                case DoctorProperty.Region:
                    return d => d.Region?.Num;
                default:
                    return d => d.Id;
            }
        }
    }

    /// <summary>
    /// Свойтсва объекта врача
    /// </summary>
    public enum DoctorProperty
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Id = 1,

        /// <summary>
        /// ФИО врача
        /// </summary>
        FIO = 2,

        /// <summary>
        /// Кабинет
        /// </summary>
        Office = 3,

        /// <summary>
        /// Специализация
        /// </summary>
        Specialization = 4,

        /// <summary>
        /// Участок
        /// </summary>
        Region = 5,
    }
}
