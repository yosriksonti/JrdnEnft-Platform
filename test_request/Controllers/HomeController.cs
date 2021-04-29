using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net.Http;
using test_request.Models;
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
            return RedirectToAction("Index", "Daycare_Front");
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
                + "\"x\" : " + position.x + ","
                + "\"y\" : " + position.y + " "
                + "}";
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
