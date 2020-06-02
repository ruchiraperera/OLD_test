using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyResolver.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyResolver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog logger;

        public HomeController(ILog logger)
        {
            this.logger = logger;
        }
        public IActionResult Index()
        {
            logger.display("display this message");
            return View();
        }
    }
}