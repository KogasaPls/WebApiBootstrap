using System;

namespace WebApiBootstrap.Contracts;

public record WeatherForecast(DateOnly Date, int TemperatureC, int? TemperatureF, string? Summary);