using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Items
{
  public class Sys
  {
    [JsonProperty("pod")]
    public string Pod { get; set; }
  }
}
