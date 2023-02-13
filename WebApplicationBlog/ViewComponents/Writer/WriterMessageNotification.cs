using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
