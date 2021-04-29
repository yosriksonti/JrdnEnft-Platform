using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using test_request.Models.admin;

namespace test_request.Controllers
{
    public class DirectorController : Controller
    {
        public static readonly HttpClient client = new HttpClient();
        private REST rest = new REST();
        // GET: Director
        public ActionResult Directors()
        {

            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/Directors");
            ViewBag.directors = response;
            return View();
        }
        public ActionResult IndexBack()
        {

            return View();
        }
        /* public ActionResult directorById()
         {
             JObject response = sendGetRequest();
             return View(response);
         }

           /*  public JObject sendGetRequest()
         {
             string response = client.GetStringAsync("http://127.0.0.1:8082/Director/1").GetAwaiter().GetResult();
             var directors = JObject.Parse(response);


             return directors;
         }*/
       
        public ActionResult Director(int? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/Director/" + id);
            ViewBag.director = response;
            return View(response);


        }
       
        public ActionResult Daycare_Director(int? id)
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/getDaycareById/" + id);
            ViewBag.daycares = response;
            return View(response);


        }
       
        public ActionResult Create()
        {
             return View();
        }


       

        [HttpPost]
        public ActionResult Create(Director director)
        {
            string values =
              "{"
             + "\"address\" : \"" + director.Address + "\","
             + "\"password\" : \"" + director.Password + "\","
             //+ "\"cin\" : " + director.Cin + ","
             //+ "\"is_active\" :  true ,"
             + "\"phonenumber\" : " + director.phonenumber + ","
             + "\"email\" : \"" + director.Email + "\","
             + "\"name\" : \"" + director.Name + "\","
             + "\"lastname\" : \"" + director.Lastname + "\""
            // + "\"roleA\" : " + 2 + ","
            // + "\"login\" : \"" + director.Login + "\","
            // + "\"birthday\" : \"" + director.Birthday.ToString("yyyy-MM-dd") + "\""
             + "}";
            Console.WriteLine(values);
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://localhost:8082/addDirector");
            Console.WriteLine(resp);
            return RedirectToAction("Directors");
        }

        public ActionResult Delete_Director(int? id)
        {
            HttpResponseMessage response = rest.sendDeleteRequest("http://127.0.0.1:8082/deleteDirector/" + id);
            Console.WriteLine(response);

            return RedirectToAction("Directors");


        }

        public ActionResult Update_Director(int ? id)
        {
            return View();
        }




        [HttpPost]
        public ActionResult Update_Director(Director director,int ? id)
        {
            string values =
              "{"
             + "\"address\" : \"" + director.Address + "\","
             + "\"password\" : \"" + director.Password + "\","
             //+ "\"cin\" : " + director.Cin + ","
             //+ "\"is_active\" :  true ,"
             + "\"phonenumber\" : " + director.phonenumber + ","
             + "\"email\" : \"" + director.Email + "\","
             + "\"image\" : \"" + director.Image + "\""
            // + "\"roleA\" : " + 2 + ","
            // + "\"login\" : \"" + director.Login + "\","
            // + "\"birthday\" : \"" + director.Birthday.ToString("yyyy-MM-dd") + "\""
             + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://localhost:8082/updateDirectorById/"+id);
            Console.WriteLine(resp);
            return RedirectToAction("Directors");
        }


    }

      


}

