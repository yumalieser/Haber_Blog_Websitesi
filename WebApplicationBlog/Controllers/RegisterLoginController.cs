using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace WebApplicationBlog.Controllers
{
    public class RegisterLoginController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbout = "Merhaba ben yeni bir yazarım.";
            wm.WriterAdd(p);
            return RedirectToAction("Index","Blog");

        }
    }
}
