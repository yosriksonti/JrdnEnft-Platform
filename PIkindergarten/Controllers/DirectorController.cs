using Newtonsoft.Json.Linq;
using PIkindergarten.Models.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PIkindergarten.Controllers
{
    public class DirectorController : Controller
    {
        public static readonly HttpClient client = new HttpClient();
        // GET: Director
        public ActionResult director()
        {
            JArray response = GetAll();
            return View(response);
        }
        /* public ActionResult directorById()
         {
             JObject response = sendGetRequest();
             return View(response);
         }

           /*  public JObject sendGetRequest()
         {
             string response = client.GetStringAsync("http://127.0.0.1:8005/Director/1").GetAwaiter().GetResult();
             var directors = JObject.Parse(response);


             return directors;
         }*/
        public JArray GetAll()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8005/getAllDirector").GetAwaiter().GetResult();
            var directors = JArray.Parse(response);


            return directors;
        }
        public ActionResult GetDirectorBy(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JObject response = sendGetRequest(id);
            //Director director = db.Movies.Find(id);
            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);


        }
        public JObject sendGetRequest(int? id)
        {
            string response = client.GetStringAsync("http://127.0.0.1:8005/Director/"+id).GetAwaiter().GetResult();
            var directors = JObject.Parse(response);


            return directors;
        }
    }
}
