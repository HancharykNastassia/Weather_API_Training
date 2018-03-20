using System;
using NUnit.Framework;
using RestSharp;
using WeatherAPI.Deserialization;
using WeatherAPI.Items;

namespace WeatherAPI.Test
{
  [TestFixture]
  public class Test
  {
    private static readonly string BASE_URL = "http://api.openweathermap.org/";
    private static readonly string RESOURCE = "/data/2.5/forecast";
    private static readonly string APP_ID = "2b97d827d6a17a2d7d44fe852cf9b9c9";
    private static readonly string CITY_ID = "2959662";

    private RestClient client;
    private RestRequest request;
    private JsonDeserializator deserializator;

    [SetUp]
    public void IntializeTest()
    {
      client = new RestClient();
      client.BaseUrl = new Uri(BASE_URL);
      request = new RestRequest();
      deserializator = JsonDeserializator.Deserializator;
    }

    [Test]
    public void TestAPIRequestWithCityId()
    {
      request.AddParameter("id", CITY_ID);
      request.AddParameter("appid", APP_ID);
      request.Resource = RESOURCE;
      request.Method = Method.GET;
      IRestResponse<ResponseContent> response = client.Execute<ResponseContent>(request);
      Assert.IsTrue(response.IsSuccessful, "Response is not received");
      ResponseContent content = deserializator.Deserialize<ResponseContent>(response);
      Assert.AreEqual(CITY_ID, content.CityInfo.Id, "Wrong response");
    }
  }
}
