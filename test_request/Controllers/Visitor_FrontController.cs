using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_request.Controllers
{
    public class Visitor_FrontController : Controller
    {
        private REST rest = new REST();

        public IActionResult Favorites(int ? id)
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/DaycareFavorite/"+id);
            ViewBag.favorites = response;
            return View();
        }
    }
}
