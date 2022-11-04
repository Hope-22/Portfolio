using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio_Project.Models;
using Portfolio_Project.Models.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServices _services;

        public HomeController(ILogger<HomeController> logger, IServices services)
        {
            _logger = logger;
            _services = services;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact(Contact contact)
        {
            var result = _services.CreateContact(contact);
            /*if(result)
                return ("Home/Index");*/
            return View();
        }
        public IActionResult Projects()
        {
            var project = _services.GetAllProject();

            if (project != null)
            {
                return View(project);
            }
            return View();  
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult NotFoundPage()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
