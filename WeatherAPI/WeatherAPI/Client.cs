using System;
using RestSharp;

namespace WeatherAPI
{
  public class Client
  {
    private RestClient client;

    public Client(string url)
    {
      client = new RestClient();
      client.BaseUrl = new Uri(url);
    }

    public IRestResponse<T> Execute<T>(CustomRestRequest request) where T : new()
    {
      return client.Execute<T>(request.Build());
    }
  }
}
