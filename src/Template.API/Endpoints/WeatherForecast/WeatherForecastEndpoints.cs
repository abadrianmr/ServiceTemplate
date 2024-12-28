namespace Template.API.Endpoints.WeatherForecast;

public static class WeatherForecastEndpoints
{
    public static IEndpointRouteBuilder MapWhetherForecastEndpoints(this IEndpointRouteBuilder routes)
    {
        return routes
            .MapGroup("wheather-forecast")
            .WithTags("01. Weather Forecast")
            .GetWeatherForecastsEndpoint();
    }
}