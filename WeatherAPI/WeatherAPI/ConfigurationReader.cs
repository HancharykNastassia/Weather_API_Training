using System;
using System.Configuration;

namespace WeatherAPI
{
  public class ConfigurationReader
  {
    public static string BASE_URL => GetConfigurationVariable("BaseUrl", "http://api.openweathermap.org/");
    public static string APP_ID => GetConfigurationVariable("AddId", String.Empty);

    public static string GetConfigurationVariable(string variable, string defaultValue)
    {
      return ConfigurationManager.AppSettings[variable] ?? defaultValue;
    }
  }
}
