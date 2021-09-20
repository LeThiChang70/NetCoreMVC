using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Demo.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult GetName()
        {
            return View();
        }
    }
}