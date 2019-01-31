using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;

namespace Clockwork.Web.Models
{
    public class CurrentTimeQueries
    {
        public List<CurrentTimeQuery> TimeQueries { get; set; }


        //public List<CurrentTimeQuery> GetTimeQueries()
        //{
        //    string apiUrl = "http://localhost:54963/api/TimeQueries";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(apiUrl);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var data = await response.Content.ReadAsStringAsync();
        //            var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);

        //        }

        //    }
        //}
    }
}