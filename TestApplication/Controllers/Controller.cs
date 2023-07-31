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
    }
}
