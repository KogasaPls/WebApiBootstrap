namespace WebApiBootstrap.Api.Models;

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    : ISerializableAs<Dto.WeatherForecast>
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public static WeatherForecast FromDto(Dto.WeatherForecast dto)
    {
        return new WeatherForecast(dto.Date, dto.TemperatureC, dto.Summary);
    }

    public Dto.WeatherForecast ToDto()
    {
        return new Dto.WeatherForecast(Date, TemperatureC, TemperatureF, Summary);
    }
}