using MediatR;

namespace Template.Application.Handlers.WeatherForecast.GetWeatherForecasts;

internal class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastQuery, IEnumerable<GetWeatherForecastResponse>>
{
    public Task<IEnumerable<GetWeatherForecastResponse>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new GetWeatherForecastResponse
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ));
        return  Task.FromResult(forecast);
    }
    
    private static readonly string[] summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];
}