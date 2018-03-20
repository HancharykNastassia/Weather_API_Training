using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class City
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("coord")]
    public Coordinates Coord { get; set; }
    [JsonProperty("country")]
    public string Country { get; set; }
  }
}
