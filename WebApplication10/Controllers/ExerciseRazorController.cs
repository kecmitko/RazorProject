using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class ExerciseRazorController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "This is data from controller";
            return View();
        }
    }
}