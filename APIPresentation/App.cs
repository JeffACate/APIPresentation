using APIPresentation;
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
            string baseUrl = "https://cat-fact.herokuapp.com";
            string options = "/facts/random";

            string endpoint = baseUrl + options;

            MakeRequest(endpoint);

            Console.WriteLine("This Ends first.");

            Console.ReadKey();
        }

        private async Task MakeRequest(string endpoint)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync(endpoint);

            Console.WriteLine();
            var obj = Json.Decode(data.ToString());

            CatFact catFact = Json.Decode<CatFact>(data);
            
            
            Console.WriteLine($"       id: {obj._id}");
            Console.WriteLine($"     text: {obj.text}");
            Console.WriteLine($"     type: {obj.type}\n");
            Console.WriteLine($"     text: {catFact.text}");
            //Console.WriteLine($" verified: {catFact.status.}");

        }
    }
}