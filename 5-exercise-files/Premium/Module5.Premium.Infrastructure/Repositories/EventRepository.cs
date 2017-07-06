using System;
using System.Collections.Generic;
using System.Linq;

namespace Module5.Premium.Infrastructure.Repositories
{
    public class EventRepository
    {
        private readonly MerloEntities _db = new MerloEntities();

        public void Store(MatchEvent eventData)
        {
            eventData.TimeStamp = DateTime.Now;
            _db.MatchEvents.Add(eventData);
            _db.SaveChanges();
        }

        public void RemoveMostRecent(string matchId)
        {
            var last = (from e in _db.MatchEvents
                where e.MatchId == matchId
                orderby e.Id descending 
                select e).FirstOrDefault();
            if (last == null)
                return;

            _db.MatchEvents.Remove(last);
            _db.SaveChanges();
        }

        public IList<MatchEvent> All(string matchId)
        {
            var events = (from e in _db.MatchEvents 
                          where e.MatchId == matchId 
                          select e).ToList();
            return events;
        }
    }
}