using System.Linq;
using Module5.Premium.Infrastructure.Common;

namespace Module5.Premium.Infrastructure.Repositories
{
    public class MatchRepository
    {
        private readonly MerloEntities _db = new MerloEntities();

        public Match FindById(string id)
        {
            var match = (from m in _db.Matches where m.Id == id select m).FirstOrDefault();
            return match;
        }

        public void DeleteById(string id)
        {
            var match = FindById(id);
            if (match == null)
                return;

            _db.Matches.Remove(match);
            _db.SaveChanges();
        }

        public void Save(Match match)
        {
            var existing = FindById(match.Id);
            if (existing == null)
            {
                _db.Matches.Add(match);
            }
            else
            {
                match.CopyPropertiesTo(existing);
            }
            _db.SaveChanges();
        }

        public IQueryable<Match> Find()
        {
            var list = (from m in _db.Matches select m);
            return list;
        }
    }
}