using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PIkindergarten.Models.admin;
using PIkindergarten.Models.doctor;

namespace PIkindergarten.Controllers
{
    public class DoctorController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private REST rest = new REST();
        public JArray sendGetRequest()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/getAllDoctors").GetAwaiter().GetResult();
            var doctors = JArray.Parse(response);
            return doctors;
        }
        // GET: Doctor
        public ActionResult Index()
        {
            JArray response = sendGetRequest();
            return View(response);
        }

        public ActionResult GetDoctorBy(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JObject response = sendGetRequestDoctorID(id);
            
            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);


        }


        public JObject sendGetRequestDoctorID(int? id)
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/Doctor/"+id).GetAwaiter().GetResult();
            var doctors = JObject.Parse(response);
           

            return doctors;
        }



        // GET: Doctor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Create(Doctor doctor)
        {
            string values =
              "{"
             + "\"address\" : \"" + doctor.Address + "\","
             + "\"password\" : \"" + doctor.Password + "\","
             + "\"cin\" : " + doctor.Cin + ","
             + "\"is_active\" :  true ,"
             + "\"phonenumber\" : " + doctor.phonenumber + ","
             + "\"email\" : \"" + doctor.Email + "\","
             + "\"name\" : \"" + doctor.Name + "\","
             + "\"lastname\" : \"" + doctor.Lastname + "\","
             + "\"roleA\" : " + 2 + ","
             + "\"login\" : \"" + doctor.Login + "\","
             + "\"birthday\" : \"" + doctor.Birthday.ToString("yyyy-MM-dd") + "\""
             + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://localhost:8080/addDoctor");
          
            return View();
        }


        /*
        public async System.Threading.Tasks.Task<ActionResult> UpdateDoctorAsync(int id)
        {
            Doctor doctor = new Doctor();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://127.0.0.1:8080/Doctor/" +id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    doctor = JsonConvert.DeserializeObject<Doctor>(apiResponse);
                }
            }
            return View(doctor);
        }


        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> UpdateDoctorAsync(Doctor doctor)
        {
            Doctor Receiveddoctor = new Doctor();
            using (var httpClient = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(doctor.id.ToString()),"Id");
                content.Add(new StringContent(doctor.Name),"Name");
                content.Add(new StringContent(doctor.Lastname),"Lastname");
                content.Add(new StringContent(doctor.Address),"Address");

                using (var response = await httpClient.PutAsync("http://localhost:8080/ModifyDoctorById", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    Receiveddoctor = JsonConvert.DeserializeObject<Doctor>(apiResponse);
                }
            }
            return View(Receiveddoctor);
        }


        */



        

            // GET: Doctor/Edit/5
            public ActionResult Edit(int? id)
            {

            ViewBag.doctorId = id;
            return View();
            }

            // POST: Doctor/Edit/5
            [HttpPost]
            public ActionResult Edit(Doctor doctor,int ? id)
            {
                string values =
                   "{"
                  + "\"id\" : \"" + doctor.id + "\","
                  + "\"address\" : \"" + doctor.Address + "\","
                  + "\"password\" : \"" + doctor.Password + "\","
                  + "\"cin\" : " + doctor.Cin + ","
                  + "\"is_active\" :  true ,"
                  + "\"phonenumber\" : " + doctor.phonenumber + ","
                  + "\"email\" : \"" + doctor.Email + "\","
                  + "\"name\" : \"" + doctor.Name + "\","
                  + "\"lastname\" : \"" + doctor.Lastname + "\","
                  + "\"roleA\" : " + 2 + ","
                  + "\"login\" : \"" + doctor.Login + "\","
                  + "\"birthday\" : \"" + doctor.Birthday.ToString("yyyy-MM-dd") + "\""
                  + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://localhost:8080/ModifyDoctorById/"+id);
            Console.WriteLine(resp);
            

                
            return RedirectToAction("Index");
        }
            

        // GET: Doctor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doctor/Delete/5
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
