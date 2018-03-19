using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Items
{
  public class WeatherItem
  {
    public string Dt { get; set; }
    public MainWeatrherInfo MainInfo { get; set; }

    public Clouds Clouds { get; set; }
    public Wind Winds { get; set; }
    public Snow Snow { get; set; }
    public Sys Sys { get; set; }
    public string DtTxt { get; set; }
  }
}
