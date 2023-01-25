using Dvojak.K8S.EdgeOperator.Configuration;
using KubeOps.Operator;

var builder = WebApplication.CreateBuilder(args);
builder.ConfigureEdgeOperatorProject();
var app = builder.Build();
app.ConfigureEdgeOperatorApp();
await app.RunOperatorAsync(args);