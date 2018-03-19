using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using WeatherAPI.Deserialization;
using WeatherAPI.Items;

namespace WeatherAPI.Test
{
  [TestFixture]
  public class Test
  {
    private static readonly string BASE_URL = "";
    private static readonly string RESOURCE = "";
    private static readonly string APP_ID = "";
    private static readonly string CITY_ID = "";

    private RestClient client;
    private RestRequest request;
    private JsonDeserializator deserializator;

    [SetUp]
    public void IntializeTest()
    {
      client = new RestClient();
      request = new RestRequest();
      deserializator = JsonDeserializator.Deserializator;
    }

    [Test]
    public void TestAPIRequestWithCityId()
    {
      client.BaseUrl = new Uri(BASE_URL);
      //request.
      request.Resource = RESOURCE;
      request.Method = Method.GET;
      IRestResponse<ResponseContent> response = client.Execute<ResponseContent>(request);
      ResponseContent content = deserializator.Deserialize<ResponseContent>(response);
      Assert.AreEqual(CITY_ID, content.CityInfo.Id, "Wrong response");
    }
  }
}
