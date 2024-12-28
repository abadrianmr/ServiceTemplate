using MediatR;

namespace Template.Application.Handlers.WeatherForecast.GetWeatherForecasts;

public sealed record GetWeatherForecastQuery() : IRequest<IEnumerable<GetWeatherForecastResponse>>;