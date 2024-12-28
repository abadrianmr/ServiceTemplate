using MediatR;
using Microsoft.OpenApi.Models;
using Template.Application.Handlers.WeatherForecast.GetWeatherForecasts;

namespace Template.API.Endpoints.WeatherForecast;

internal static class GetWeatherForecasts
{
    private static readonly string summary = "Template summary";
    private static readonly string description = "Template description";

    internal static IEndpointRouteBuilder GetWeatherForecastsEndpoint(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("", async (ISender sender) =>
            {
                var query = new GetWeatherForecastQuery();
                
                var result = await sender.Send(query);
                
                return TypedResults.Ok(result);
            })
            .WithOpenApi(ops => new OpenApiOperation(ops)
            {
                Summary = summary,
                Description = description
            });

        return routes;
    }
}

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}