using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class NotifiactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
