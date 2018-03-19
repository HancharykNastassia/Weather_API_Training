using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.Items
{
  public class Wind
  {
    [JsonProperty("speed")]
    public string Speed { get; set; }
    [JsonProperty("deg")]
    public string Deg { get; set; }
  }
}
