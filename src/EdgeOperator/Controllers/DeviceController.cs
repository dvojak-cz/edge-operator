using Dvojak.K8S.EdgeOperator.Entities;

using KubeOps.Operator.Controller;
using KubeOps.Operator.Controller.Results;
using KubeOps.Operator.Rbac;

namespace Dvojak.K8S.EdgeOperator.Controllers;

[EntityRbac(typeof(Device),Verbs = RbacVerb.All)]
public class DeviceController : IResourceController<Device>
{
    private readonly ILogger<DeviceController> _logger;

    public DeviceController(ILogger<DeviceController> logger)
    {
        _logger = logger;
    }

    public async Task<ResourceControllerResult?> ReconcileAsync(Device entity)
    {
        return null;
    }

    public async Task StatusModifiedAsync(Device entity)
    {
    }

    public async Task DeletedAsync(Device entity)
    {
    }
}