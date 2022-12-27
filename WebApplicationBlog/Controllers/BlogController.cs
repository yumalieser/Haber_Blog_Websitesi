using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
