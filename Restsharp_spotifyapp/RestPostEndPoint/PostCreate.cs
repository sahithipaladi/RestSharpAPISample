using System;
using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;


namespace RestSharpAPI.RestPostEndPoint
{
    [TestClass]
    public class TestPostEndPoint
    {
        private string postUrl = "https://reqres.in/api/users";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestPostUsingRestSharp()
        {
            string JsonData = "{" +
                               "\"name\": \"morpheus\" ," +
                               "\"job\": \"leader\" ," +
                               "}";

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(postUrl);
            restResponse = restClient.Post(restRequest);
            restRequest.AddJsonBody(JsonData);
            Assert.AreEqual(201, (int)restResponse.StatusCode);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("StatusCode : " + restResponse.StatusCode);
                Console.WriteLine("Response : " + restResponse.Content);

            }
            Console.WriteLine(restResponse.ErrorMessage);
            Console.WriteLine(restResponse.ErrorException);


           

        }

    }
}