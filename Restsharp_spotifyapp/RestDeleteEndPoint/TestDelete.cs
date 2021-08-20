/*
 * project = Validating the webservices like put,post,del,get
 * Author = sahithi paladi
 * Created Date = 18/08/2021
 */
using System;
using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace RestSharpAPI.RestDeleteEndPoint
{
    [TestClass]
    public class TestDeleteEndPoint
    {
        private string DelUrl = "https://reqres.in/api/users/2";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestDeleteUsingRestSharp()
        {

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(DelUrl);
            restResponse = restClient.Delete(restRequest);
            Assert.AreEqual(204, (int)restResponse.StatusCode);

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