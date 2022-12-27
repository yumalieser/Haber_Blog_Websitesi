using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
