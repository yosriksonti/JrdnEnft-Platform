using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using test_request.Models.daycare;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_request.Controllers
{
    public class Daycare_BackController : Controller
    {
        private REST rest = new REST();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Daycares()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares");
            ViewBag.daycares = response;
            return View();
        }
        public IActionResult Add_Daycare()
        {
            JArray directors = rest.sendGetArrayRequest("http://127.0.0.1:8082/Directors");
            JArray managers = rest.sendGetArrayRequest("http://127.0.0.1:8082/Managers");
            ViewBag.directors = directors;
            ViewBag.managers = managers;
            return View();
        }

        [HttpPost]
        public IActionResult Add_Daycare(Daycare daycare)
        {
            string values =
                 "{"
                + "\"logo\" : \"" + daycare.logo + "\","
                + "\"daycareName\" : \"" + daycare.daycareName + "\", "
                + "\"region\" : \"" + daycare.region + "\","
                + "\"nbReclamation\" : 0, "
                + "\"reputation\" : \"inconnue\", "
                + "\"manager\" : { "
                    + "\"id\" : \"" + daycare.manager + "\" "
                + " },"
                + "\"director\" : { "
                    + "\"id\" : \"" + daycare.director + "\" "
                + " }"
                +"}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8082/daycares/add");
            Console.WriteLine(resp);
            return Add_Daycare();

        }
    }
}
