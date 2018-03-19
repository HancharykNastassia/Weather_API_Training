using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using SimpleJson;
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

    public JsonDeserializator Deserializator => deserializator ?? (deserializator = new JsonDeserializator());

    public T Deserialize<T> (IRestResponse response)
    {
      if (response == null)
      {
        throw new ArgumentNullException(nameof(response));
      }
      var serializator = new JsonSerializer();
      using (StreamReader stream = new StreamReader(response.Content))
      {
        JsonTextReader reader = new JsonTextReader(stream);
        object result = serializator.Deserialize(reader);
        return (T)result;
      }
    }
  }
}
