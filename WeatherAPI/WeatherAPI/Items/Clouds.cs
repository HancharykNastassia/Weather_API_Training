using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class Clouds
  {
    [JsonProperty("all")]
    public string All { get; set; }
  }
}
