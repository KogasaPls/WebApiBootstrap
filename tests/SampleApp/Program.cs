using System.Text.Json;

using WebApiBootstrap.Client;
using WebApiBootstrap.Contracts;

// Proof of concept showing that the thing works.
// You should set up the client with the dependency injection container properly.

using HttpClient httpClient = new HttpClient {BaseAddress = new Uri("http://localhost:5078")};
using MyApiClient client = new MyApiClient(httpClient);
ICollection<WeatherForecast>? forecast = await client.GetWeatherForecast.Execute();
string forecastJson = JsonSerializer.Serialize(
    forecast,
    new JsonSerializerOptions {WriteIndented = true});

Console.WriteLine(forecastJson);