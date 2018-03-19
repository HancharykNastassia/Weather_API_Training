using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class MainWeatrherInfo
  {
    [JsonProperty("temp")]
    public string Temp { get; set; }
    public string MaxTemp { get; set; }
    public string MinTemp { get; set; }
    public string Pressure { get; set; }
    public string SeaLevel { get; set; }
    public string GroundLevel { get; set; }
    public string Hummidity { get; set; }
    public string Temp_kf { get; set; }
  }
}
