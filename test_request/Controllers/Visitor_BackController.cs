using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_request.Controllers
{
    public class Visitor_BackController : Controller
    {
        private REST rest = new REST();

        // GET: /<controller>/
        public IActionResult Visitors()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/Visitors");
            ViewBag.visitors = response;
            return View();
        }
        public IActionResult Visitor(int? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/Visitor/" + id);
            ViewBag.daycare = response;
            return View();
        }
        public IActionResult Delete_Visitor(int? id)
        {
            HttpResponseMessage response = rest.sendDeleteRequest("http://127.0.0.1:8082/deleteVisitor/" + id);
            return RedirectToAction("Visitors", "Visitor_Back");
        }
    }
}
