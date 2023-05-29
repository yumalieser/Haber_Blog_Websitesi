using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace WebApplicationBlog.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            string WeatherApiKey = "82c11d84dd1445edc029ffc1816f3ed1";
            string wConnection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + WeatherApiKey;
            XDocument wDocument= XDocument.Load(wConnection);
            ViewBag.v4 = wDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
