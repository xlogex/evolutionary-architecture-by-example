namespace EvolutionaryArchitecture.Fitnet.Contracts.IntegrationEvents;

using Common.Infrastructure.Events;

public sealed record ContractSignedEvent(Guid Id, Guid ContractId, Guid ContractCustomerId, DateTimeOffset SignedAt, DateTimeOffset ExpireAt, DateTimeOffset OccurredDateTime) : IIntegrationEvent
{
    public static ContractSignedEvent Create(Guid contractId, Guid contractCustomerId, DateTimeOffset signedAt, DateTimeOffset expireAt) =>
        new(Guid.NewGuid(), contractId, contractCustomerId, signedAt, expireAt, DateTimeOffset.UtcNow);
}