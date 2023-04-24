using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
