using Newtonsoft.Json;
using NUnit.Framework;

namespace Ic_june2021
{
    public class BaseTest
    {

         CustomerAPI custApi;
       
        public readonly static string email = "user17@sector36.com";
        public readonly static string password = "user@12023";

        [OneTimeSetUp]
        public void Setup()
        {
            custApi = new CustomerAPI();
            User user = new User(email, password);
            string auth = JsonConvert.SerializeObject(user);
            BaseAPI BA = new BaseAPI();
            string token = BA.GetAuthToken(auth);
            BaseAPI.token = token;
        }

    }
}