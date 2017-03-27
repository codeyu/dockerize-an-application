using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("[controller]/[action]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}