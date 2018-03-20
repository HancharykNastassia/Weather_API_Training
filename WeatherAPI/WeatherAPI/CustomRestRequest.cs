using RestSharp;

namespace WeatherAPI
{
  public class CustomRestRequest
  {
    private RestRequest request => new RestRequest();
    
    public CustomRestRequest AddParameter(Parameter param)
    {
      request.AddParameter(param);
      return this;
    }

    public CustomRestRequest AddParameter(string param, object value)
    {
      request.AddParameter(param, value);
      return this;
    }

    public CustomRestRequest AddParameter(string param, object value, ParameterType type)
    {
      request.AddParameter(param, value, type);
      return this;
    }

    public CustomRestRequest SetResource(string resourse)
    {
      request.Resource = resourse;
      return this;
    }

    public CustomRestRequest SetMethod(Method method)
    {
      request.Method = method;
      return this;
    }

    public RestRequest Build()
    {
      return this.request;
    }
  }
}
