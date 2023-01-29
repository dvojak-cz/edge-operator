using Dvojak.K8S.EdgeOperator.Definitions;
using k8s.Models;
using KubeOps.KubernetesClient.Entities;
using KubeOps.Operator.Entities;
using KubeOps.Operator.Entities.Annotations;

namespace Dvojak.K8S.EdgeOperator.Entities;

[KubernetesEntity(
    Group = Api.Group,
    ApiVersion = Api.ApiVersion
    )]
[EntityScope(EntityScope.Cluster)]
public class Device : CustomKubernetesEntity<Device.DeviceEntitySpec,Device.DeviceEntityStatus>
{
    public class DeviceEntitySpec
    {
        [Description("Name of the node where the device is connected to")]
        [Required]
        public string NodeName { get; set; } = string.Empty;

        [Required] public string IpAddress { get; set; } = string.Empty;
        [Required] public int Port { get; set; } = 0;
        [Required] public bool IsUp { get; set; } = false;
        [Required] public bool Ping { get; set; } = false;
    }
    public class DeviceEntityStatus
    {
        public bool? Ready = null;
    }

}