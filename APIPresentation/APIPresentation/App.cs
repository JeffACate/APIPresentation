using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace AppNameSpace
{
    class App
    {
        public void Run()
        {
            // formatRequest()
            // callAPI()
            // formatResponse()
            // displayResponse()

            string baseUrl = "https://cat-fact.herokuapp.com";
            string options = "/facts/random";

            string endpoint = baseUrl + options;

            MakeRequest(endpoint);

            Console.ReadKey();
        }

        private async Task MakeRequest(string endpoint)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync(endpoint);

            Console.WriteLine();
            var obj = Json.Decode(data.ToString());

            Console.WriteLine($"       id: {obj._id}");
            Console.WriteLine($"     text: {obj.text}");
            Console.WriteLine($"     type: {obj.type}");
            Console.WriteLine($"createdAt: {obj.createdAt}");

            return ;

        }
    }
}