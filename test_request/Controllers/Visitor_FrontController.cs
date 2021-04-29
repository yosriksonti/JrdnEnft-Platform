using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using test_request.Models.visitor;

namespace test_request.Controllers
{
    public class Visitor_FrontController : Controller
    {
        private REST rest = new REST();


        public IActionResult Favorites(int? id)
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/DaycareFavorite/" + id);
            ViewBag.favorites = response;
            return View();
        }

        public IActionResult Add_Favorite(int? id)
        {
            string daycareId = Request.Query["daycare"];
            string values =
                             "{"
                            + "\"id\" : \"" + id + "\","
                            + "\"visitor\" : { "
                                + "\"id\" : \"" + id + "\" "
                            + " }"
                            + "}";

            HttpResponseMessage response = rest.sendPutRequest(values, "http://localhost:8082/affecterDaycareFavorite/"+daycareId);
            return RedirectToAction("Favorites","Visitor_Front",new { id = id } );
        }

        public IActionResult Remove_Favorite(int? id)
        {
            string daycareId = Request.Query["daycare"];
            string values =
                             "{"
                            + "\"id\" : \"" + id + "\","
                            + "\"visitor\" : { "
                                + "\"id\" : \"" + id + "\" "
                            + " }"
                            + "}";

            HttpResponseMessage response = rest.sendPutRequest(values, "http://localhost:8082/supprimerDaycareFavorite/" + daycareId);
            return RedirectToAction("Favorites", "Visitor_Front", new { id = id });
        }

        public IActionResult VIP(int? id)
        {
            string values =
                 "{"
                + "\"id\" : \"" + 1 + "\","
                + "\"amount\" : \"" + 150 + "\", "
                + "\"visitor\" : { "
                    + "\"id\" : \"" + id + "\" "
                + " }"
                + "}";

            HttpResponseMessage response = rest.sendPostRequest(values, "http://localhost:8082/addPayment");
            string strresponse = response.Content.ReadAsStringAsync().Result;
            return Redirect(strresponse);
        }
        public IActionResult paymentSuccess()
        {
            Console.WriteLine("QUERY", Request.Query["payment_ref"]);
            var response = rest.sendGetRequest("http://localhost:8082/payment?payment_ref=" + Request.Query["payment_ref"]);
            return RedirectToAction("Index", "Daycare_Front");
            //ViewBag.response = Request.Query["payment_ref"];
            //return View();
        }

        public IActionResult Add_Visitor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add_Visitor(Visitor visitor)
        {
            string values =
                "{"
               + "\"name\" : \"" + visitor.Name + "\","
               + "\"email\" : \"" + visitor.Email + "\", "
               + "\"address\" : \"" + visitor.Address + "\","
               + "\"phonenumber\" :" + visitor.phonenumber + ", "
               + "\"lastname\" : \"" + visitor.Lastname + "\", "
               + "\"password\" : \"" + visitor.Password + "\", "
               + "\"cin\" : \"" + visitor.Cin + "\", "
               + "\"login\" : \"" + visitor.Login + "\", "
               + "\"status\" : \"" + visitor.status + "\", "
               + "\"birthday\" : \"" + visitor.Birthday.ToString("yyyy-MM-dd") + "\", "
               + "\"filedb\" : { "
                   + "\"id\" : \"" + "9c89b260 - 72ed - 4c23 - b317 - e8d5c44b39de" + "\" "
               + " },"
               + "\"position\" : { "
                   + "\"id\" : \"" + 1 + "\" "
               + " }"
               + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8082/addVisitor/9c89b260-72ed-4c23-b317-e8d5c44b39de");
            Console.WriteLine(resp);
            return RedirectToAction("Index", "Daycare_Front");
        }
        public IActionResult Visitor(int? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/Visitor/" + id);
            ViewBag.visitor = response;
            return View();
        }
        public IActionResult Update_Visitor(int ? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/Visitor/" + id);
            ViewBag.visitor = response;
            return View();
        }

        [HttpPost]
        public IActionResult Update_Visitor(Visitor visitor,int ? id)
        {
            string values =
                "{"
               + "\"id\" : \"" + id+ "\","
               + "\"name\" : \"" + visitor.Name + "\","
               + "\"email\" : \"" + visitor.Email + "\", "
               + "\"address\" : \"" + visitor.Address + "\","
               + "\"phonenumber\" :" + visitor.phonenumber + ", "
               + "\"lastname\" : \"" + visitor.Lastname + "\", "
               + "\"password\" : \"" + visitor.Password + "\", "
               + "\"cin\" : \"" + visitor.Cin + "\", "
               + "\"login\" : \"" + visitor.Login + "\", "
               + "\"status\" : \"" + visitor.status + "\", "
               + "\"birthday\" : \"" + visitor.Birthday.ToString("yyyy-MM-dd") + "\", "
               + "\"filedb\" : { "
                   + "\"id\" : \"" + "9c89b260-72ed-4c23-b317-e8d5c44b39de" + "\" "
               + " },"
               + "\"position\" : { "
                   + "\"id\" : \"" + 1 + "\" "
               + " }"
               + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://localhost:8082/updateVisitor/" + id);
            Console.WriteLine(resp);
            return RedirectToAction("Index", "Daycare_Front");
        }

        public IActionResult Closest_Daycares(int ? id)
        {
            string values =
                "{"
               + "\"id\" : \"" + id + "\""
               + "}";
            JArray response = rest.sendPostArrayRequest(values, "http://localhost:8082/visitor/closestDaycares");
            JObject response3 = rest.sendGetObjectRequest("http://127.0.0.1:8082/Visitor/14");
            ViewBag.visitor = response3;
            ViewBag.daycares = response;
            return View();
        }
    }
}
