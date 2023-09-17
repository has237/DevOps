using BookReadingEvent.Interfaces;
using BookReadingEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventPageService _eventPageService;

        //private readonly ILogger<AccountController> _logger;

        //public HomeController(ILogger<AccountController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IEventPageService eventPageService)
        {
            this._eventPageService = eventPageService;
        }
        [Route("")]
        public async Task<IActionResult> Index()
        {
            var eventList = await _eventPageService.GetEvents();
            return View(eventList);
        }

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("about-us")]
        public IActionResult About()
        {
            return View();
        }

        [Route("customer-support")]
        public IActionResult CustomerSupport()
        {
            return Redirect("http://helpdesk.nagarro.com");
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
