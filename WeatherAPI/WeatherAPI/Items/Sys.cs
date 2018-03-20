using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class Sys
  {
    [JsonProperty("pod")]
    public string Pod { get; set; }
  }
}
