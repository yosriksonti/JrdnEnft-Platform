using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json.Linq;
using PIkindergarten.Models.manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web.Mvc;

namespace PIkindergarten.Controllers
{
    public class appointementController : Controller
    {

        public List<string> googleevents = new List<string>();
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        // GET: appointement
        public ActionResult Index()
        {
            calenderEvents();
            ViewBag.EventList = googleevents;
            System.Diagnostics.Debug.WriteLine(ViewBag.EventList);
            return View();
        }


        public ActionResult OauthRedirect()
        {
            var credentialsFile = "C:\\Users\\MSI\\Documents\\PIkindergarten (2)\\PIkindergarten\\PIkindergarten\\Files";
            JObject credentials = JObject.Parse(System.IO.File.ReadAllText(credentialsFile));
            var client_id=credentials["client_id"];
            var redirect_uri= "https://accounts.google.com/o/oauth2/v2/auth?"+
                       "scope = https://www.googleapis.com/auth/calendar+:https://www.googleapis.com/auth/calendar.events	&" +
                         "access_type = offline &" +
                            "include_granted_scopes = true &"+
                             "response_type = code &"+
                                 "state = hellothere &"+
                                 "redirect_uri = https://localhost:44319/oauth/callback&" +
                                   "client_id ="  +client_id;
            return View();
        }

        // GET: appointement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: appointement/Create
        public ActionResult Create()
        {
            return View();
        }










        public void calenderEvents()
        {
            UserCredential credential;
            string path = Server.MapPath("credentials.json");
            using (var stream =
                new FileStream(path, FileMode.Open, FileAccess.Read))
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

            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    googleevents.Add(eventItem.Organizer.Email);

                }
            }


        }

    }
    // POST: appointement/Create
    [HttpPost]
    public ActionResult Create(Appointement appointement)
    {
        try
        {
            // TODO: Add insert logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET: appointement/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: appointement/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add update logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET: appointement/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: appointement/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }
}
}
