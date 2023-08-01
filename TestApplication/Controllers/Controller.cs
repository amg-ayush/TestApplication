using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    /// <summary>
    /// Базовый контроллер
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public abstract class Controller : ControllerBase
    {
        protected const int takeCount = 10;

        protected void CheckPageNum(int pageNum)
        {
            if (pageNum < 1) throw new Exception("Указан некорректный номер страницы.");
        }

        protected void CheckProperty<T>(int sortProperty)
        {
            if (!Enum.IsDefined(typeof(T), sortProperty))
                throw new Exception("Указан некорректный номер свойтсва.");
        }
    }
}
