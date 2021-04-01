using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace AppNameSpace
{
    class App
    {
        public void Run()
        {
            // formatData()
            // callAPI()
            // formatResponse()
            // displayResponse()

            string baseUrl = "https://cat-fact.herokuapp.com";
            string options = "/facts/random";

            string endpoint = baseUrl + options;

            WebRequest req = WebRequest.Create(endpoint);
            req.Method = "GET";

            var res = req.GetResponse();

            var stream = res.GetResponseStream();

            var reader = new StreamReader(stream);

            var data = Json.Decode(reader.ReadToEnd());
            Console.WriteLine($"       id: {data._id}");
            Console.WriteLine($"     text: {data.text}");
            Console.WriteLine($"     type: {data.type}");
            Console.WriteLine($"createdAt: {data.createdAt}");
            Console.ReadKey();
        }
    }
}