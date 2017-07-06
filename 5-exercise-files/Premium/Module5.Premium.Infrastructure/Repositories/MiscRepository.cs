namespace Module5.Premium.Infrastructure.Repositories
{
    public class MiscRepository
    {
        private readonly MerloEntities _db = new MerloEntities();

        public void ResetDb()
        {
            // Empty both DBs
            foreach (var m in _db.Matches)
            {
                _db.Matches.Remove(m);
            }
            foreach (var mev in _db.MatchEvents)
            {
                _db.MatchEvents.Remove(mev);
            }
            _db.SaveChanges();
        }
    }
}