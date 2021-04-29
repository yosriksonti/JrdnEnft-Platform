﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_request.Controllers
{
    public class Daycare_FrontController : Controller
    {
        private REST rest = new REST();

        // GET: /<controller>/
        public IActionResult Index()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/visitor/14/daycares");
            JObject response3 = rest.sendGetObjectRequest("http://127.0.0.1:8082/Visitor/14");
            ViewBag.visitor = response3;
            ViewBag.daycares = response;
            return View();
        }
        public IActionResult Daycare(int? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/daycares/" + id);
            JArray response2 = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares/" + id + "/posts");
            ViewBag.daycare = response;
            ViewBag.posts = response2;
            Console.WriteLine(response2);
            return View();
        }


    }
}
