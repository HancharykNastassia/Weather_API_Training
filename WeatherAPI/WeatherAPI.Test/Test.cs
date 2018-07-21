using NUnit.Framework;
using RestSharp;
using WeatherAPI.Deserialization;
using WeatherAPI.Items;

namespace WeatherAPI.Test
{
  [TestFixture]
  public class Test
  {
    //private Client client;
    //private CustomRestRequest request;
    //private JsonDeserializator deserializator;

    //[SetUp]
    //public void IntializeTest()
    //{
    //  client = new Client(ConfigurationReader.BASE_URL);
    //  request = new CustomRestRequest();
    //  deserializator = JsonDeserializator.Deserializator;
    //}

    [Test]
    public void TestAPIRequestWithCityId()
    {
      string cityId = "524901";
      //request.AddParameter("id", cityId);
      //request.AddParameter("appid", ConfigurationReader.APP_ID);
      //string resource = "/data/2.5/forecast";
      //request.SetResource(resource);
      //request.SetMethod(Method.GET);

      //IRestResponse<ResponseContent> response = client.Execute<ResponseContent>(request);
      //Assert.IsTrue(response.IsSuccessful, "Response is not received");
      //ResponseContent content = deserializator.Deserialize<ResponseContent>(response);
      ResponseContent content = new ForecastRequest().FormRequest(cityId).Execute();
      Assert.AreEqual(cityId, content.CityInfo.Id, "Wrong response");
    }
  }
}
