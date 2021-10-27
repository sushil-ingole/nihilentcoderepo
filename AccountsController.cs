using System;
//using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMVCApp.Models;

// This is new changes being added for filter addition
//These are Ravi Tambade
//Edit by nitin
namespace WebMVCApp.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Accounts(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
             
           return View();
        }

        
        
        public IActionResult Aboutus(){
               Console.WriteLine("Aboutus  Method is invoked.....");
            
             return View();
        }

    }
}
