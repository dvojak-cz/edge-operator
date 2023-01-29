using System.Net;
using Dvojak.K8S.EdgeOperator.Entities;
using k8s;
using k8s.Models;
using KubeOps.Operator.Webhooks;

namespace Dvojak.K8S.EdgeOperator.Validators;
/*
public class DeviceValidator : IValidationWebhook<Device>
{
    // private readonly KubernetesClient _kubernetesClient;
    // private readonly ILogger<DeviceValidator> _logger;

    public DeviceValidator()
    {
        // _kubernetesClient = kubernetesClient;
        // _logger = logger;
    }

    public AdmissionOperations Operations => AdmissionOperations.All;


    private ValidationResult Test(Device newEntity,bool dryRun)
    {
        // _logger.LogDebug($"Validating device {newEntity.Metadata.Name}");
        if (!ValidateIp(newEntity.Spec.IpAddress))
        {
            // _logger.LogWarning($"Validating device {newEntity.Metadata.Name} failed: Invalid IP address");
            return ValidationResult.Fail(StatusCodes.Status400BadRequest,"Invalid IP address");
        }


        if (!ValidatePort(newEntity.Spec.Port))
        {
            // _logger.LogWarning($"Validating device {newEntity.Metadata.Name} failed: Invalid port");
            return ValidationResult.Fail(StatusCodes.Status400BadRequest,"Invalid port");
        }


//        if (!await ValidateNodeExists(newEntity.Spec.NodeName))
//        {
//            _logger.LogWarning($"Validating device {newEntity.Metadata.Name} failed: Invalid node name");
//            return ValidationResult.Fail(StatusCodes.Status400BadRequest,"Invalid node name");
//        }

        // _logger.LogDebug($"Validating device {newEntity.Metadata.Name}: Validation successful");
        return ValidationResult.Success();
    }

    public async Task<ValidationResult> CreateAsync(Device newEntity,bool dryRun) => Test(newEntity,dryRun);

    public async Task<ValidationResult> UpdateAsync(Device oldEntity,Device newEntity,bool dryRun) => Test(newEntity,dryRun);

    public ValidationResult Create(Device newEntity,bool dryRun)
        => Test(newEntity,dryRun);

    public ValidationResult Update(Device oldEntity,Device newEntity,bool dryRun) => Test(newEntity,dryRun);

    public ValidationResult Delete(Device oldEntity,bool dryRun) => ValidationResult.Success();

    public async Task<ValidationResult> DeleteAsync(Device oldEntity,bool dryRun) => ValidationResult.Success();

    // private async Task<bool> ValidateNodeExists(string nodeName)
    // {
        // var node = await _kubernetesClient.Get<V1Node>(nodeName);
        // return node != null;
    // }

    private bool ValidateIp(string ip) => IPAddress.TryParse(ip,out _);

    private bool ValidatePort(int port) => port > 0 && port < 65536;
}*/