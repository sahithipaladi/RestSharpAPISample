using System;
using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;


namespace RestSharpAPI.RestPutEndPoint
{
    [TestClass]
    public class TestPutEndPoint
    {
        private string putUrl = "https://reqres.in/api/users/2";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestPutUsingRestSharp()
        {
            string JsonData = "{" +
                               "\"name\": \"morpheus\" ," +
                               "\"job\": \"zion resident\" ," +
                               "}";

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(putUrl);
            restResponse = restClient.Put(restRequest);
            restRequest.AddJsonBody(JsonData);
            Assert.AreEqual(200, (int)restResponse.StatusCode);

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