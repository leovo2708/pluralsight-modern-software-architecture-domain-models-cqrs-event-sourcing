using System;

namespace Module5.Deluxe.CommandStack.Domain.Common
{
    public class DomainEvent 
    {
        public DateTime TimeStamp { get; private set; }

        public DomainEvent()
        {
            TimeStamp = DateTime.Now;
        }
    }
}