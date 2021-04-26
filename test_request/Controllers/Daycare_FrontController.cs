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
    public class Daycare_FrontController : Controller
    {
        private REST rest = new REST();

        // GET: /<controller>/
        public IActionResult Index()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares");
            ViewBag.daycares = response;
            return View();
        }
        public IActionResult Daycare(int ? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/daycares/"+id);
            ViewBag.daycare = response;
            return View();
        }
    }
}
