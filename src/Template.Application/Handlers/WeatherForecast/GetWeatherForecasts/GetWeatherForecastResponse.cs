namespace Template.Application.Handlers.WeatherForecast.GetWeatherForecasts;

readonly record struct GetWeatherForecastResponse(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}