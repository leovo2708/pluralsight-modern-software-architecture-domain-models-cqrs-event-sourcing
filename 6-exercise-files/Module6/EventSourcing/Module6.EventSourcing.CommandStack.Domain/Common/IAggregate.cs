using System;
using System.Collections.Generic;

namespace Module6.EventSourcing.CommandStack.Domain.Common
{
    public interface IAggregate
    {
        Guid Id { get; }
        bool HasPendingChanges { get; }
        IEnumerable<DomainEvent> GetUncommittedEvents();
        void ClearUncommittedEvents(); 
    }
}