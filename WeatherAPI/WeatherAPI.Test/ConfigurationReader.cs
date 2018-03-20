using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WeatherAPI.Test
{
  public class ConfigurationReader
  {
    public static string BASE_URL => GetConfigurationVariable("BaseUrl", "http://api.openweathermap.org/");
    public static string APP_ID => GetConfigurationVariable("AppId", String.Empty);

    public static string GetConfigurationVariable(string variable, string defaultValue)
    {
      return ConfigurationManager.AppSettings[variable] ?? defaultValue;
    }
  }
}
