using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace PIkindergarten.Models.doctor
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

      

        public HttpResponseMessage sendPostRequest(string body, string url)
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