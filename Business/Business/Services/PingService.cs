using Business.Abstract.Services;
using Domain.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PingService : IPingServices
    {
        public async Task<List<Ping>> getPingList()
        {
            List<Ping> list = new List<Ping>();
            try
            {
                string url = "http://10.50.10.14:81/PingList";
                Uri baseurl = new Uri(url);
                RestClient client = new RestClient(baseurl);
                RestRequest request = new RestRequest(baseurl, Method.Get);

                var response = await client.ExecuteAsync<List<Ping>>(request);
                List<Ping> ping = JsonConvert.DeserializeObject<List<Ping>>(response.Content);

                return ping;
            }
            catch (Exception x)
            { 
                throw x;
            }
        }

    }
}
