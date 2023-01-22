using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Controllers
{
    public class NewsletterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus=true;
            nm.AddNewsLetter(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
