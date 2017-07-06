using System.Web.Script.Serialization;
using Module6.EventSourcing.CommandStack.Events;
using Module6.EventSourcing.Infrastructure.EventStore.SqlServer.Repositories;
using Module6.EventSourcing.SharedKernel;

namespace Module6.EventSourcing.CommandStack.Domain.Services
{
    public class HistoryService
    {
        public SlotHistory GetHistory(int aggregateId)
        {
            var serializer = new JavaScriptSerializer();
            var history = new SlotHistory {BookingId = aggregateId};

            var events = new EventRepository().All(aggregateId);
            foreach (var e in events)
            {
                var slot = new SlotInfo();
                switch (e.Action)
                {
                    case "BookingCreatedEvent":
                        var createdEvent = serializer.Deserialize<BookingCreatedEvent>(e.Cargo);
                        slot = createdEvent.Data;
                        slot.Action = "Created";
                        slot.When = createdEvent.When.ToLocalTime();;
                        slot.BookingId = createdEvent.Id;
                        break;
                    case "BookingUpdatedEvent":
                        var updatedEvent = serializer.Deserialize<BookingUpdatedEvent>(e.Cargo);
                        slot = updatedEvent.Data;
                        slot.Action = "Updated";
                        slot.When = updatedEvent.When.ToLocalTime();
                        slot.BookingId = updatedEvent.Id;
                        break;
                }

                history.ChangeList.Add(slot);
            }
            return history;
        }
    }
}