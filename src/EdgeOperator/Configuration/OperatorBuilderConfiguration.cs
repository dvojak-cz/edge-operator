using KubeOps.Operator;
using Serilog;

namespace Dvojak.K8S.EdgeOperator.Configuration;

public static class OperatorBuilderConfiguration
{
    public static void ConfigureEdgeOperatorProject(this WebApplicationBuilder builder)
    {
        ConfigureLogging(builder.Configuration, builder.Logging);
        // ConfigureDatabase(builder.Configuration, builder.Services);
        // ConfigureAuth(builder.Configuration, builder.Services);
        // ConfigureAuth0ManagementApi(builder.Configuration, builder.Services);
        // ConfigureCors(builder.Services);
        // ConfigureWebServerService(builder.Configuration, builder.Services);
        ConfigureRuntimeDiService(builder.Services);
        // ConfigureSwagger(builder.Services);
    }

    private static void ConfigureLogging(IConfiguration configuration, ILoggingBuilder logging)
    {
        // === Logging Setup ===
        logging.ClearProviders();
        logging.AddSerilog(new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger());
    }
    private static void ConfigureRuntimeDiService(IServiceCollection builderServices)
    {
        // === DI Setup ===
        builderServices.AddKubernetesOperator();
    }
}
