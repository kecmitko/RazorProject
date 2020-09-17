using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*_logger.LogDebug("start.....");
            ///kod
           
            var item = new TasksToDo();
            item.RedenBroj = 1;

            try
            {

            }
            catch (Exception e)
            {
                _logger.LogError(e.Messages);
            }

            _logger.LogDebug("json from item******************");*/
            return View();
        }

        public IActionResult Privacy(int number, string name, bool isEven)
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}
