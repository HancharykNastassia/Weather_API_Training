using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class Coordinates
  {
    [JsonProperty("lon")]
    public string Lon { get; set; }
    [JsonProperty("lat")]
    public string Lat { get; set; }
  }
}