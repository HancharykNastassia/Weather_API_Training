using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class Clouds
  {
    [JsonProperty("all")]
    public string All { get; set; }
  }
}
