using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class MainWeatrherInfo
  {
    [JsonProperty("temp")]
    public string Temp { get; set; }
    [JsonProperty("temp_max")]
    public string MaxTemp { get; set; }
    [JsonProperty("temp_min")]
    public string MinTemp { get; set; }
    [JsonProperty("pressure")]
    public string Pressure { get; set; }
    [JsonProperty("sea_level")]
    public string SeaLevel { get; set; }
    [JsonProperty("grnd_level")]
    public string GroundLevel { get; set; }
    [JsonProperty("humidity")]
    public string Humidity { get; set; }
    [JsonProperty("temp_kf")]
    public string Temp_kf { get; set; }
  }
}
