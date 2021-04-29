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
    public class Daycare_BackController : Controller
    {
        private REST rest = new REST();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Daycares()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares");
            ViewBag.daycares = response;
            return View();
        }
        public IActionResult Posts(int ? id)
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares/"+id+"/posts");
            ViewBag.posts = response;
            return View();
        }

        public IActionResult Post(int? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/posts/" + id );
            ViewBag.post = response;
            return View();
        }
        public IActionResult Add_Post(int ? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add_Post(Post post,int ? id)
        {
            string values =
                  "{"
                + "\"body\" : \"" + post.body + "\","
                + "\"title\" : \"" + post.title + "\", "
                + "\"media\" : \"" + post.media + "\","
                + "\"creationDate\" : \"" + post.creationDate.ToString("yyyy-MM-dd") + "\", "
                + "\"modificationDate\" : \"" + post.creationDate.ToString("yyyy-MM-dd") + "\", "
                + "\"daycare\" : { "
                    + "\"id\" : \"" + id + "\" "
                + " }"
                + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8082/posts/add");
            return RedirectToAction("Posts", "Daycare_Back",new { id = id });

        }

        public IActionResult Update_Post(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update_Post(Post post, int? id)
        {
            string values =
                  "{"
                + "\"id\" : \"" + id + "\","
                + "\"body\" : \"" + post.body + "\","
                + "\"title\" : \"" + post.title + "\", "
                + "\"media\" : \"" + post.media + "\","
                + "\"creationDate\" : \"" + post.creationDate.ToString("yyyy-MM-dd") + "\", "
                + "\"modificationDate\" : \"" + post.creationDate.ToString("yyyy-MM-dd") + "\" "
                + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://127.0.0.1:8082/posts/update");
            return RedirectToAction("Post", "Daycare_Back", new { id = id });

        }

        public IActionResult Add_Daycare()
        {
            JArray directors = rest.sendGetArrayRequest("http://127.0.0.1:8082/Directors");
            JArray managers = rest.sendGetArrayRequest("http://127.0.0.1:8082/Managers");
            ViewBag.directors = directors;
            ViewBag.managers = managers;
            return View();
        }

        [HttpPost]
        public IActionResult Add_Daycare(Daycare daycare)
        {
            string values =
                 "{"
                + "\"logo\" : \"" + daycare.logo + "\","
                + "\"daycareName\" : \"" + daycare.daycareName + "\", "
                + "\"region\" : \"" + daycare.region + "\","
                + "\"nbReclamation\" : 0, "
                + "\"reputation\" : \"inconnue\", "
                + "\"manager\" : { "
                    + "\"id\" : \"" + daycare.manager + "\" "
                + " },"
                + "\"director\" : { "
                    + "\"id\" : \"" + daycare.director + "\" "
                + " }"
                +"}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://127.0.0.1:8082/daycares/add");
            Console.WriteLine(resp);
            return RedirectToAction("Daycares","Daycare_Back");

        }
        public IActionResult Update_Daycare(int ? id)
        {
            JArray directors = rest.sendGetArrayRequest("http://127.0.0.1:8082/Directors");
            JArray managers = rest.sendGetArrayRequest("http://127.0.0.1:8082/Managers");
            ViewBag.directors = directors;
            ViewBag.managers = managers;
            ViewBag.daycareId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Update_Daycare(Daycare daycare,int ? id)
        {
            string values =
                 "{"
                + "\"id\" : \"" + id + "\","
                + "\"logo\" : \"" + daycare.logo + "\","
                + "\"daycareName\" : \"" + daycare.daycareName + "\", "
                + "\"region\" : \"" + daycare.region + "\","
                + "\"reputation\" : \"" + daycare.reputation + "\", "
                + "\"manager\" : { "
                    + "\"id\" : \"" + daycare.manager + "\" "
                + " },"
                + "\"director\" : { "
                    + "\"id\" : \"" + daycare.director + "\" "
                + " }"
                + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://127.0.0.1:8082/daycares/update");
            Console.WriteLine(resp);
            return RedirectToAction("Daycares", "Daycare_Back");

        }
        public IActionResult Delete_Daycare(int? id)
        {
            HttpResponseMessage response = rest.sendDeleteRequest("http://127.0.0.1:8082/daycares/" + id + "/delete");
            return RedirectToAction("Daycares");
        }
        public IActionResult Daycares_Statistics()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/daycares/statistics");
            ViewBag.daycares = response;
            return View();
        }

    }
}
