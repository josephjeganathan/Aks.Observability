namespace Aks.Observability;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(option => option.EnableEndpointRouting = false);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseCors(c =>
        {
            c.AllowAnyOrigin();
            c.AllowAnyHeader();
        });

        app
            .UseHttpsRedirection()
            .UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}