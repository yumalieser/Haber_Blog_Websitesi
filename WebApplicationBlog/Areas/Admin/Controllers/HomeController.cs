﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBlog.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
