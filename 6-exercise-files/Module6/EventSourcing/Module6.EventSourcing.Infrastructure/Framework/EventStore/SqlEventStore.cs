using System.Collections.Generic;
using System.Web.Script.Serialization;
using Module6.EventSourcing.Infrastructure.EventStore.SqlServer.Data;
using Module6.EventSourcing.Infrastructure.EventStore.SqlServer.Repositories;

namespace Module6.EventSourcing.Infrastructure.Framework.EventStore
{
    public class SqlEventStore : IEventStore
    {
        private static readonly EventRepository EventRepository = new EventRepository();

        public IEnumerable<Event> All(string matchId)
        {
            return null; //EventRepository.All(matchId);
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var loggedEvent = new LoggedEvent()
            {
                Action = theEvent.Name,
                AggregateId = theEvent.SagaId,
                Cargo = new JavaScriptSerializer().Serialize(theEvent)
            };

            EventRepository.Store(loggedEvent);
        }
    }
}