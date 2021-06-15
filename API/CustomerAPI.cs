using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ic_june2021
{
    class CustomerAPI:BaseAPI
    {

        public IRestResponse GetAllRecord()

        {
            string Url = $"{baseUrl}/{version}/customers";
            var client = new RestClient(Url);

            var request = new RestRequest(Method.GET);
            //header
            request.AddHeader("Content-Type", "application/json");
            _ = request.AddHeader("Authorization", $"bearer {token}");
            IRestResponse response = client.Execute(request);
            TestContext.WriteLine(response.Content);
            return response;

        }

    
        public IRestResponse GetSingleRecord(string id)

        {
            string Url = $"{baseUrl}/{version}/customers/{id}";
            var client = new RestClient(Url);
            var request = new RestRequest(Method.GET);
            //header
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"bearer {token}");
            IRestResponse response = client.Execute(request);
            TestContext.WriteLine(response.Content);
            return response;
        }

        public IRestResponse PostCustomer(string body)


        {
            string Url = $"{baseUrl}/{version}/customers";
            var client = new RestClient(Url);

            var request = new RestRequest(Method.POST);
            //header
            request.AddHeader("Content-Type", "application/json");
            _ = request.AddHeader("Authorization", $"bearer {token}");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response;
        }

        public IRestResponse deleteRecord(string id)

        {
            string Url = $"{baseUrl}/{version}/customers/{id}";
            var client = new RestClient(Url);

            var request = new RestRequest(Method.DELETE);
            //header
            request.AddHeader("Content-Type", "application/json");
            _ = request.AddHeader("Authorization", $"bearer {token}");
            IRestResponse response = client.Execute(request);
            TestContext.WriteLine(response.Content);
            return response;
        }

     

        public IRestResponse UpdatedRecord(string body)


        {
            string Url = $"{baseUrl}/{version}/customers/234";
            var client = new RestClient(Url);

            var request = new RestRequest(Method.PUT);
            //header
            request.AddHeader("Content-Type", "application/json");
            _ = request.AddHeader("Authorization", $"bearer {token}");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            TestContext.WriteLine(response.Content);
            return response;
        }
    }
}
