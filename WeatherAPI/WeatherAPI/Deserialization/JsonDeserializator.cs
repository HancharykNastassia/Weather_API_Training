using System;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.IO;

namespace WeatherAPI.Deserialization
{
  public class JsonDeserializator
  {
    private static JsonDeserializator deserializator;

    private JsonDeserializator()
    {
    }

    public static JsonDeserializator Deserializator => deserializator ?? (deserializator = new JsonDeserializator());

    public T Deserialize<T> (IRestResponse response)
    {
      if (response == null)
      {
        throw new ArgumentNullException(nameof(response));
      }
      var serializator = new JsonSerializer();
      using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(response.Content)))
      {
        StreamReader firstReader = new StreamReader(stream);
        JsonTextReader reader = new JsonTextReader(firstReader);
        var result = serializator.Deserialize<T>(reader);
        return result;
      }
    }
  }
}
