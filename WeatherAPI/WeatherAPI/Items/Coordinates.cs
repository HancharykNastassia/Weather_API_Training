using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using SimpleJson;
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