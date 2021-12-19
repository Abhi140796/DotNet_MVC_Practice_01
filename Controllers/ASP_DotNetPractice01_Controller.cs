using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_MVC_Practice_01.Controllers
{
    public class ASP_DotNetPractice01_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string list()
        {
            return "List function";
        }

        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}
