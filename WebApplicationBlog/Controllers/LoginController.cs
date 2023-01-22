using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
