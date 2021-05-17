using CleanArchitecture.Domain.Core.Events;
using System;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTimeOffset Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTimeOffset.Now;
        }
    }
}
