using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PIkindergarten.Models.manager;

namespace PIkindergarten.Controllers
{
    public class EventController : Controller
    {
      //  public List<string> googleevents = new List<string>();
       // static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
       // static string ApplicationName = "Google Calendar API .NET Quickstart";
        private static readonly HttpClient client = new HttpClient();
        private Rest rest = new Rest();
        // GET: Event
        public JArray sendGetRequest()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/SpringMVC/servlet/getAllEvenement").GetAwaiter().GetResult();
            var doctors = JArray.Parse(response);
            Console.WriteLine(doctors);
            return doctors;
        }
        public ActionResult Index()
        {
            
            JArray response = sendGetRequest();
            return View(response);
        }


        public ActionResult getmanagers()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/SpringMVC/servlet/getAllmanagers").GetAwaiter().GetResult();
            var doctors = JArray.Parse(response); 
            return View(doctors);
        }

        public ActionResult getappointments()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/SpringMVC/servlet/getAllappointments").GetAwaiter().GetResult();
            var appointments = JArray.Parse(response);
            return View(appointments);
        }
        public ActionResult indexback()
        {
            JArray response = sendGetRequest();
            return View(response);
        }

        // GET: Event/Details/5
        public ActionResult Details(int ?id)
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
            string response = client.GetStringAsync("http://127.0.0.1:8080/SpringMVC/servlet/getEvenementById/" + id).GetAwaiter().GetResult();
            var directors = JObject.Parse(response);


            return directors;
        }
     

        // GET: Event/Create
        [HttpPost]
        public ActionResult Create(Evenement evenement)
        {
            string values =
                  "{"
                 + "\"name\" : \"" + evenement.name + "\","
                 + "\"type\" : \"" + evenement.type + "\", "
                 + "\"date\" : \"" + evenement.date + "\", "
                 + "\"nbParticipant\" : " + evenement.nbParticipant + ", "
                 + "\"atelier\" : \"" + evenement.atelier + "\" "
                 
                 + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8080/SpringMVC/servlet/ajouterEvenement/196a82d7-7c2a-4865-a20d-bb7677255d90");
            return Create();
        }
        public ActionResult Create()
        {
            return View();
        }
      
        // POST: Event/Create
        [HttpPost]
        public ActionResult appointment(Appointement appointement,int ? id)
        {
            string values =
                  "{" + "\"parent\" : { "
                    + "\"id\" : \"" + appointement.parent.id + "\" "
                + " }," 
                 + "\"maneger\" : { "
                    + "\"id\" : \"" + id + "\" "
                + " }"
                + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8080/SpringMVC/servlet/appointementsadd");
            return Create();
        }

        public ActionResult appointment(int ? id)
        {
            JArray parents = rest.sendGetArrayRequest("http://localhost:8080/SpringMVC/servlet/getAllparents");
            ViewBag.managerid = id;
            ViewBag.parents = parents;
            return View();
        }



        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {   
            JObject response = sendGetRequest(id);
            if (response == null)
            {
                return HttpNotFound();

            }
            Evenement evenement=new Evenement(int.Parse(response["id"].ToString()), response["name"].ToString(), response["type"].ToString(), Convert.ToDateTime(response["date"].ToString()) , response["image"].ToString(), int.Parse(response["nbParticipant"].ToString()), response["atelier"].ToString(),null);
            return View(evenement);
        }

        // POST: Event/Edit/5
        [HttpPost]


        public ActionResult Edit(int id, Evenement evenement)
        {
            string values =
                   "{"
                  + "\"name\" : \"" + evenement.name + "\","
                  + "\"type\" : \"" + evenement.type + "\", "
                  + "\"date\" : \"" + evenement.date + "\", "
                  + "\"nbParticipant\" : " + evenement.nbParticipant + ", "
                  + "\"atelier\" : \"" + evenement.atelier + "\" "

                  + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://localhost:8080/SpringMVC/servlet/updateEvenement/"+ id );
            return RedirectToAction("indexback", "Event"); ;

        }
        public ActionResult participer(int ? id)
        {
            JObject response = sendGetRequest(id);

            Evenement evenement = new Evenement(int.Parse(response["id"].ToString()), null);

            return View(evenement);
        }
        [HttpPost]
        public ActionResult participer(int id,int idp, Evenement evenement)
        {
            JArray parents = rest.sendGetArrayRequest("http://localhost:8080/SpringMVC/servlet/getAllparents");
            ViewBag.parents = parents;

            JObject response = sendGetRequest(id);
            if (response == null)
            {
                return HttpNotFound();

            }
            string values =

                  "{" + "\"manager\" : { "
                    + "\"id\" : \"" + evenement.manager.id + "\" "
               
                + "}";
            HttpResponseMessage resp = rest.sendPutRequest("", "http://localhost:8080/SpringMVC/servlet/affecterparentAevenement/" +id+"/"+idp);
            return Edit(id);

        }
        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Evenement evenement)
        {
            HttpResponseMessage response = rest.sendDeleteRequest("http://localhost:8080/SpringMVC/servlet/deleteevenementById/" + id);
            return Delete(id);


        }

        public ActionResult calend()
        {
            //calenderEvents();
            //ViewBag.EventList = googleevents;
            return View();
        }


        /*    public void calenderEvents()
            {
                UserCredential credential;
                string path = Server.MapPath("credentials.json");
                using (var stream =
                    new FileStream(path,FileMode.Open, FileAccess.Read))
                {
                    // The file token.json stores the user's access and refresh tokens, and is created
                    // automatically when the authorization flow completes for the first time.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Create Google Calendar API service.
                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define parameters of request.
                EventsResource.ListRequest request = service.Events.List("primary");
                request.TimeMin = DateTime.Now;
                request.ShowDeleted = false;
                request.SingleEvents = true;
                request.MaxResults = 10;
                request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                // List events.
                Events events = request.Execute();
                Console.WriteLine("Upcoming events:");
                if (events.Items != null && events.Items.Count > 0)
                {
                    foreach (var eventItem in events.Items)
                    {
                        googleevents.Add(eventItem.Summary);

                    }
                }


            }*/

    }
}
