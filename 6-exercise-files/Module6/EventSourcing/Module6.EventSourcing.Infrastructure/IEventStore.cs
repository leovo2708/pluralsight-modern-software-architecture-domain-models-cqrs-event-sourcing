using System.Collections.Generic;
using Merlo.Eda.Infrastructure.SqlServer;

namespace Merlo.Eda.Infrastructure
{
    public interface IEventStore
    {
        //IEnumerable<T> Find<T>(Func<T, bool> filter);
        IEnumerable<MatchEvent> All(string matchId);

        void Save<T>(T theEvent) where T : EventBase;
    }
}