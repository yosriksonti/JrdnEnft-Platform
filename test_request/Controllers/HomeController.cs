using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test_request.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using test_request.Models.daycare;


namespace test_request.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private REST rest = new REST();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares");
            ViewBag.daycares = response;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Position position)
        {
            string values =
                 "{"
                +"\"x\" : "+position.x+","
                +"\"y\" : "+position.y+" "
                +"}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8082/position/add");
            return Index();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
