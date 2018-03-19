using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Items
{
  public class WeatherItem
  {
    [JsonProperty("dt")]
    public string Dt { get; set; }
    [JsonProperty("main")]
    public MainWeatrherInfo MainInfo { get; set; }
    [JsonProperty("weather")]
    public Weather[] Weather { get; set; }
    [JsonProperty("clouds")]
    public Clouds Clouds { get; set; }
    [JsonProperty("wind")]
    public Wind Winds { get; set; }
    [JsonProperty("snow")]
    public Snow Snow { get; set; }
    [JsonProperty("sys")]
    public Sys Sys { get; set; }
    [JsonProperty("dt_txt")]
    public string DtTxt { get; set; }
  }
}
