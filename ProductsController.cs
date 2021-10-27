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
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProductsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
             
           return View();
        } 
//         public IActionResult Products(){
//                Console.WriteLine("Products  Method is invoked.....");
            
//              return View();
//         }
    }
}
