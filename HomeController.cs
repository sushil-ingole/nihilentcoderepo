using System;
//using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMVCApp.Models;

// This is new changes being added for filter addition
namespace WebMVCApp.Controllers
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
            Console.WriteLine("Index Method is invoked.....");
            return View();
        }

        public IActionResult Privacy()
        {

               Console.WriteLine("Privacy Method is invoked.....");
            return View();
        }

        public IActionResult Aboutus(){
               Console.WriteLine("Aboutus  Method is invoked.....");
            
             return View();
        }
        public IActionResult Contactus(){
               Console.WriteLine("Contactus Method is invoked.....");

             return View();
        }

        public IActionResult List(){
             Console.WriteLine("List Method is invoked.....");
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
   
        //Automatic memory management
        //in Dotnet Core by one Thread------Garbage Collector
        //CLR (Common Lanaguage Runtime)
        // consist of Assembly loader, JIT,
        // and Garbage Collector
    }
}
