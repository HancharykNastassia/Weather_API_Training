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
    private static readonly string RESOURCE = "";
    private static readonly string APP_ID = "";
    private static readonly string CITY_ID = "";

    private RestRequest request;
    private JsonDeserializator deserializator;

    [SetUp]
    public void IntializeTest()
    {
      request = new RestRequest();
      deserializator = JsonDeserializator.Deserializator;
    }

    [Test]
    public void TestAPIRequestWithCityId()
    {
      //request.
      request.Resource = RESOURCE;
      request.Method = Method.GET;
    }
  }
}
