using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace test_request.Controllers
{
    public class REST
    {
        public static readonly HttpClient client = new HttpClient();

        public REST()
        {
            client.DefaultRequestHeaders
      .Accept
      .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public JArray sendGetArrayRequest(string url)
        {
            string response = client.GetStringAsync(url).GetAwaiter().GetResult();
            var jarray = JArray.Parse(response);

            return jarray;
        }
        public JObject sendGetObjectRequest(string url)
        {
            string response = client.GetStringAsync(url).GetAwaiter().GetResult();
            var jobject = JObject.Parse(response);

            return jobject;
        }


        public HttpResponseMessage sendPostRequest(string body,string url)
        {
            var httpContent = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(url, httpContent).GetAwaiter().GetResult();
            return response;

        }

        public HttpResponseMessage sendPutRequest(string body, string url)
        {
            var httpContent = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync(url, httpContent).GetAwaiter().GetResult();
            return response;

        }
        public HttpResponseMessage sendDeleteRequest(string url)
        {
            HttpResponseMessage response = client.DeleteAsync(url).GetAwaiter().GetResult();
            return response;

        }
    }
}
