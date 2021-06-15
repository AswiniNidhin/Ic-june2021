using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace Ic_june2021
{
    internal class BaseAPI
    {
      
      
        public static string baseUrl = "http://api.qaauto.co.nz/api";
        public static string version = "v1";
        public static string token;

        public string GetAuthToken(string auth)
        {
            var client = new RestClient($"{baseUrl}/{version}/auth/login");

            var request = new RestRequest(Method.POST);
            //header
            request.AddHeader("Content-Type", "application/json");
            //how to set a body
            request.AddParameter("application/json", auth, ParameterType.RequestBody);
            RestSharp.IRestResponse response = client.Execute(request);
            //read data
            string jsondata = response.Content;

            //deserialize json

            Token datatoken = JsonConvert.DeserializeObject<Token>(jsondata);
            return datatoken.access_token;

            //TestContext.WriteLine(datatoken.access_token);
            //TestContext.WriteLine(response.Content);



        }
    }
  
    
}