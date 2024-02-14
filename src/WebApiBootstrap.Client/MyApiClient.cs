using System;
using System.Net.Http;

using Refit;

namespace WebApiBootstrap.Client;

public class MyApiClient : IMyApiClient, IDisposable
{
    private readonly HttpClient _httpClient;

    public MyApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        GetWeatherForecast = RestService.For<IGetWeatherForecastEndpoint>(_httpClient);
    }

    public IGetWeatherForecastEndpoint GetWeatherForecast { get; }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}