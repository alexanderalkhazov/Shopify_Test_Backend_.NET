namespace API.Endpoints;

public static class EndpointExtensions
{
    public static WebApplication MapApiEndpoints(this WebApplication app)
    {
        app.MapShopifyEndpoints();
        
        app.MapGroup("/health")
            .WithTags("Health")
            .MapHealthEndpoints();
        
        //
        // var apiV1 = app.MapGroup("/api/v1")
        //     .WithTags("API v1")
        //     .WithOpenApi();
        //
        // apiV1.MapGroup("/jobs")
        //     .WithTags("Background Jobs")
        //     .MapJobEndpoints();
        //
        return app;
    }
}