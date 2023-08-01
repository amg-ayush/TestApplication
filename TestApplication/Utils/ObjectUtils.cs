using Microsoft.EntityFrameworkCore;
using TestApplication.BussinesObjects;

namespace TestApplication.Utils
{
    /// <summary>
    /// Вспомогательный класс для работы с бизнес-объектами
    /// </summary>
    public static class ObjectUtils
    {
        /// <summary>
        /// Получение объекта по идентификатору
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="dbTable">Таблица в БД</param>
        /// <param name="id">Идентификатор объекта</param>
        /// <param name="nullObject">Признак возвращения null-объекта</param>
        /// <exception cref="Exception">Исключение при отсутствии объекта</exception>
        public static T GetObject<T>(this DbSet<T> dbTable, int id, bool nullObject = false) where T : BaseObject
        {
            T result = dbTable.FirstOrDefault(o => o.Id == id);
            if (result == null && !nullObject)
                throw new Exception($"Объект с идентификатором id={id}, не найден.");
            return result;
        }

        /// <summary>
        /// Выполнение прогрузки связанных свойств объекта
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="db">Контекст БД</param>
        /// <param name="thisObject">Текущий объект</param>
        /// <param name="properties">Свойства для подгрузки</param>
        public static void LoadProperties<T>(this ApplicationContext db, T thisObject, params string[] properties)
            where T : BaseObject
        {
            foreach (string property in properties)
                db.Entry(thisObject).Reference(property).Load();
        }

        /// <summary>
        /// Возвращает список объектов с подгруженными связанными свойствами
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="dbTable">Таблица в БД</param>
        /// <param name="properties">Свойства для подгрузки</param>
        public static List<T> GetLoadedList<T>(this DbSet<T> dbTable, params string[] properties)
            where T : BaseObject
        {
            IQueryable<T> result = dbTable;
            
            foreach (string property in properties)
                result = result.Include(property);

            return result.ToList();
        }
    }
}
