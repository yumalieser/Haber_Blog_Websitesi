using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
