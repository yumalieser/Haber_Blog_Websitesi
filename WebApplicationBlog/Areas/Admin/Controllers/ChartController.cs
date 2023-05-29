﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationBlog.Areas.Admin.Models;

namespace WebApplicationBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10,
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14,
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 6,
            });
            return Json(new {jsonlist = list});
        }
    }
}