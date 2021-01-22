using System.Collections.Generic;
using MediatR;

namespace Domain.SeedWork
{
    public interface IAggregateRoot
    {
        IReadOnlyList<INotification> DomainEvents { get; }

        void RemoveDomainEvent(INotification eventItem);

        void ClearDomainEvents();

    }
}
