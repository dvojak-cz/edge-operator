using KubeOps.Operator;

namespace Dvojak.K8S.EdgeOperator.Configuration;

public static class OperatorAppConfiguration
{
    public static void ConfigureEdgeOperatorApp(this WebApplication app)
    {
        app.UseKubernetesOperator();
    }
}