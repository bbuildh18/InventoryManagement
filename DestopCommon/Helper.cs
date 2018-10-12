using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DestopCommon
{
    public static class Helper
    {


        public static async Task<string> PostAsync(string url, string postString)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync(
               "http://localhost:2429/api/values", Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(postString));
            return response.Content.ReadAsStringAsync().Result;

        }


        public static string GetAsync(string url)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response =  client.GetAsync(
               "http://localhost:2429/api/values").Result;
            return response.Content.ReadAsStringAsync().Result;

        }
    }
}
