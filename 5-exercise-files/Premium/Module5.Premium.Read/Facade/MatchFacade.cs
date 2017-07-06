using System.Collections.Generic;
using System.Linq;
using Module5.Premium.Infrastructure;
using Module5.Premium.Infrastructure.Repositories;
using Module5.Premium.Read.Dto;
using Module5.Premium.Shared;

namespace Module5.Premium.Read.Facade
{
    public class MatchFacade
    {
        private readonly MatchRepository _matchRepository = new MatchRepository();

        // Runs a plain query against the relational list of scheduled matches.
        /*
         * Should be noted we ideally need a relational table with only three columns. 
         * In alternative, adding a CREATE event for match which should include a 
         * DATE of play to make query of scheduled matches reliable. It depends :)
         * 
         * Here I'm using the SAME db as previous examples also to feed the LIVE module
         * effectively.
         */ 
        public IList<MatchListItem> FindScheduled()
        {
            var queryForMatches = _matchRepository.Find();
            var scheduledMatches = (from m in queryForMatches
                where m.State == (int) MatchState.ToBePlayed
                select new MatchListItem()
                {
                    Id = m.Id,
                    Team1 = m.Team1,
                    Team2 = m.Team2
                }).ToList<MatchListItem>();
            return scheduledMatches;
        }

        public IList<MatchInProgress> FindInProgress()
        {
            var queryForMatches = _matchRepository.Find();
            const int codeInProgressFrom = (int) MatchState.ToBePlayed;
            const int codeInProgressTo = (int) MatchState.Finished;

            var matches = (from m in queryForMatches 
                           where m.State > codeInProgressFrom && m.State < codeInProgressTo
                           select m).ToList();  
            var liveMatches = (from m in matches
                select new MatchInProgress()
                {
                    Id = m.Id,
                    Team1 = m.Team1,
                    Team2 = m.Team2,
                    Goal1 = m.Score1.ToString(),
                    Goal2 = m.Score2.ToString(),
                    Period = m.Period.ToString(),
                    State = (MatchState) m.State,
                    TimeoutSummary1 = m.Timeouts1,
                    TimeoutSummary2 = m.Timeouts2
                }).ToList<MatchInProgress>();
            return liveMatches;
        }

        public MatchInProgress FindById(string id)
        {
            var match = _matchRepository.FindById(id);
            return CopyToMatchInProgress(match);
        }



        #region Private
        private MatchInProgress CopyToMatchInProgress(Match match)
        {
            var mip = new MatchInProgress
            {
                Id = match.Id,
                State = (MatchState)match.State,
                Team1 = match.Team1,
                Team2 = match.Team2,
                Goal1 = match.Score1 < 0 ? "" : match.Score1.ToString(),
                Goal2 = match.Score2 < 0 ? "" : match.Score2.ToString(),
                Period = match.Period <= 0 ? "" : match.Period.ToString(),
                TimeoutSummary1 = match.Timeouts1,
                TimeoutSummary2 = match.Timeouts2
            };
            return mip;
        } 
        #endregion
    }
}