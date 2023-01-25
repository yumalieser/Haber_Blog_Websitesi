using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
