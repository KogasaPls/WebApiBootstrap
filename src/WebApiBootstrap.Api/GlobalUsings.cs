// Allows using "Dto" as a namespace prefix instead of suffix, so "Dto.WeatherForecast" instead of "WeatherForecastDto"

global using Dto = WebApiBootstrap.Contracts;

// Unless we explicitly use the "Dto." prefix, we assume that we're referring to the Models namespace.
global using WebApiBootstrap.Api.Models;

// Allows using "Convert.ToDto" instead of "Dto.Convert.ToDto"
global using Convert = WebApiBootstrap.Api.Convert;