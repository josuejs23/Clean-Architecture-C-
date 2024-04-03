using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public abstract class AggregateRoot
    {
        private readonly List<DoaminEvent> _domainEvents = new();
        public ICollection<DoaminEvent> GetDoaminEvents() => _domainEvents;
        protected void Raise(DoaminEvent doaminEvent)
        {
            _domainEvents.Add(doaminEvent);
        }
    }
}