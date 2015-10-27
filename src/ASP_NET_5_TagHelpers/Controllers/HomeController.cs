using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_5_TagHelpers.Models;
using Microsoft.AspNet.Mvc;

namespace ASP_NET_5_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult BootstrapInputGroup()
        {
            ViewData["Message"] = "Bootstrap Input Group Without Tag Helpers.";

            return View();
        }

        public IActionResult BootstrapInputGroupWithTagHelpers()
        {
            ViewData["Message"] = "Bootstrap Input Group Without Tag Helpers.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public IActionResult WithoutTagHelper()
        {
            return View(new ToDoListItem() { ItemId = 1, Text = "Tag helpers öğren", IsCompleted = true });
        }

        public IActionResult WithTagHelper()
        {
            return View(new ToDoListItem() { ItemId = 1, Text = "Tag helpers öğren", IsCompleted = true });
        }
    }
}
