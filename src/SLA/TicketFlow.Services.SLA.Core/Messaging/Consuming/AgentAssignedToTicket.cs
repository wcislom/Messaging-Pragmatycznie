﻿using TicketFlow.Shared.Messaging;
using TicketFlow.Shared.Messaging.Partitioning;

namespace TicketFlow.Services.SLA.Core.Messaging.Consuming;

public record AgentAssignedToTicket(Guid TicketId, int Version, Guid agentId) : IMessage, IMessageWithPartitionKey, ITicketChange
{
    public string PartitionKey => TicketId.ToString();
    public string ToHumanReadableString() => this.ToHumanReadableChange();
}