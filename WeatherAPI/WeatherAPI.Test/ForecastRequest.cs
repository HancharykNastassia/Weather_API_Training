using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Deserialization;
using WeatherAPI.Items;

namespace WeatherAPI.Test
{
  public class ForecastRequest
  {
    CustomRestRequest Request { get; set; }

    public ForecastRequest FormRequest(string cityID)
    {
      return new ForecastRequest()
      {
        Request = new CustomRestRequest()
                    .AddParameter("id", cityID)
                    .AddParameter("appid", ConfigurationReader.APP_ID)
                    .SetResource(ConfigurationReader.SOURCE)
                    .SetMethod(Method.GET)
      };
    }

    public ResponseContent Execute()
    {
      return JsonDeserializator.Deserializator.Deserialize<ResponseContent>(new Client(ConfigurationReader.BASE_URL).Execute<ResponseContent>(request));
    }
  }
}


