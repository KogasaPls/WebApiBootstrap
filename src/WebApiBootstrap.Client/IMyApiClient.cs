namespace WebApiBootstrap.Client;

public interface IMyApiClient
{
    IGetWeatherForecastEndpoint GetWeatherForecast { get; }
}