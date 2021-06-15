using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace Ic_june2021
{
    public class CustomerTest : BaseTest
    {
        [Test]
        public void create_customer_Test()
        {
            Customer expCustomer = new Customer();
            expCustomer.company_name = "Test";
            expCustomer.vat_number = "test";
            expCustomer.phone = "Test";
            expCustomer.website = "test@.com";
            expCustomer.currency = "234";
            expCustomer.currency = "Aus";
            expCustomer.currency = "eng";


            //set data
            string jsonbody = JsonConvert.SerializeObject(expCustomer);
            CustomerAPI custApi = new CustomerAPI();
            IRestResponse responseData = custApi.PostCustomer(jsonbody);
            TestContext.WriteLine(responseData.Content);
            //deserilize
            // Movies m = JsonConvert.DeserializeObject<Movie>(json);
            CustomerResponse res = JsonConvert.DeserializeObject<CustomerResponse>(responseData.Content);
            TestContext.WriteLine(res.data.id);
        }




    }
}