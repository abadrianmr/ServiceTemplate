using Template.API.Endpoints.WeatherForecast;

namespace Template.API;

internal static class TemplateApiDependencies
{
    private static readonly int ApiV1 = 1;
    private static readonly string AppName = "template";

    internal static void Register(IServiceCollection services)
    {
        
    }
    
    internal static void UseTemplateApiEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints
            .MapGroup($"/api/{AppName}/v{ApiV1}")
            .MapWhetherForecastEndpoints();
    }
}