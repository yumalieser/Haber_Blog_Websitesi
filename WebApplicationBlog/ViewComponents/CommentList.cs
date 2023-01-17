using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationBlog.Models;

namespace WebApplicationBlog.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    Username = "Ali"
                },
                new UserComment {
                    Id = 2,
                    Username = "Mahmut"
                },
                new UserComment{
                    Id = 3,
                    Username = "Ceren"
                }
            };
            return View(commentvalues);
        }
    }
}
