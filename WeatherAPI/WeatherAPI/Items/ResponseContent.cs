using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class ResponseContent
  {
    [JsonProperty("list")]
    public WeatherItem[] Weather { get; set; }
    [JsonProperty("city")]
    public City CityInfo { get; set; }
  }
}
