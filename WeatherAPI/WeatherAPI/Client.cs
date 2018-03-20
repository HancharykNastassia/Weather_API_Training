using System;
using RestSharp;

namespace WeatherAPI
{
  public class Client
  {
    private RestClient client;

    public Client()
    {
      client = new RestClient();
      client.BaseUrl = new Uri(ConfigurationReader.BASE_URL);
    }

    public IRestResponse<T> Execute<T>(CustomRestRequest request) where T : new()
    {
      return client.Execute<T>(request.Build());
    }
  }
}
