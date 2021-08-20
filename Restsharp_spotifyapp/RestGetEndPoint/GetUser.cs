using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;


namespace Restsharp_spotifyapp.RestGetEndPoint
{
    [TestClass]
    public class GetUser
    {
        private string getUrl = "https://reqres.in/api/users/2";

        private static IRestResponse restResponse { get; set; }

        [TestMethod]

        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);


            restResponse = restClient.Get(restRequest);

            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code :" + restResponse.StatusCode);
                Console.WriteLine("Response :" + restResponse.Content);
            }
            Console.WriteLine(restResponse.ErrorMessage);
            Console.WriteLine(restResponse.ErrorException);
        }
    }
}
