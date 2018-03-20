using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class Weather
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("main")]
    public string MainCondition { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
  }
}
