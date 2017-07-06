using System;
using Module5.Premium.Shared;
using Module5.Premium.Shared.Extensions;

namespace Module5.Premium.Command.Model
{
    public class Match  
    {
        // Id, Team1, Team2 immutable => if they change, it is another match. 
        // Consider adding a new type for these 3 properties.
        public static Match Undefined = new Match("", "", "");

        // Constants
        private const int TotalPeriodsInMatch = 4;
        private const int MaxTimeoutsPerPeriod = 1;

        public Match()
        {
            InitializeAsDefault();
        }

        public Match(String id, String team1, String team2)
        {
            InitializeAsDefault();
            Id = id;
            Team1 = team1;
            Team2 = team2;
            State = MatchState.ToBePlayed;
        }

        public String Id { get; private set; }
        public String Team1 { get; private set; }
        public String Team2 { get; private set; }
        public Int32 TimeoutCount1 { get; internal set; }
        public Int32 TimeoutCount2 { get; internal set; }
        public Score CurrentScore { get; internal set; }
        public Boolean IsBallInPlay { get; private set; }
        public Int32 CurrentPeriod { get; internal set; }
        public MatchState State { get; internal set; }
        public String Venue { get; set; }
        public DateTime Day { get; set; }   // deserves further thinking in relationship with Score/State

        #region Informational

        public Boolean IsValid()
        {
            return !String.IsNullOrWhiteSpace(Id) &&
                   !String.IsNullOrWhiteSpace(Team1) &&
                   !String.IsNullOrWhiteSpace(Team2) &&
                   State != MatchState.Unknown;
        }
        public Boolean CanRequestTimeout(TeamId id)
        {
            if (id == TeamId.Home && TimeoutCount1 < MaxTimeoutsPerPeriod)
                return true;
            if (id == TeamId.Visitors && TimeoutCount2 < MaxTimeoutsPerPeriod)
                return true;
            return false;
        }
        public Boolean IsInProgress()
        {
            return State > MatchState.ToBePlayed && State < MatchState.Finished;
        }
        public Boolean IsFinished()
        {
            return State == MatchState.Finished;
        }
        public Boolean IsScheduled()
        {
            return State == MatchState.ToBePlayed;
        }
        public String TimeoutSummary(TeamId id)
        {
            if (id == TeamId.Unknown)
                return String.Empty;

            var count = id == TeamId.Home ? TimeoutCount1 : TimeoutCount2;
            return String.Format("{0}/{1}", count, MaxTimeoutsPerPeriod);
        }

        public override String ToString()
        {
            return IsScheduled()
                ? String.Format("{0} vs. {1}", Team1, Team2)
                : String.Format("{0} / {1}  {2}", Team1, Team2, CurrentScore);
        }
        #endregion

        #region Behavior
        /// <summary>
        /// Starts the match
        /// </summary>
        /// <returns>this</returns>
        public Match Start()
        {
            if (!IsValid())
                return this;

            State = MatchState.Warmup;
            return this;
        }

        /// <summary>
        /// Ends the match
        /// </summary>
        /// <returns></returns>
        public void Finish()
        {
            if (!IsValid())
                return;

            State = MatchState.Finished;
        }

        /// <summary>
        /// Scores a goal
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Match Goal(TeamId id)
        {
            if (!IsValid())
                return this;

            if (id == TeamId.Home)
            {
                CurrentScore = new Score(CurrentScore.TotalGoals1.Increment(),
                                         CurrentScore.TotalGoals2);
            }
            if (id == TeamId.Visitors)
            {
                CurrentScore = new Score(CurrentScore.TotalGoals1,
                                         CurrentScore.TotalGoals2.Increment());
            }

            return this;
        }

        /// <summary>
        /// Starts next period
        /// </summary>
        /// <returns>this</returns>
        public Match StartPeriod()
        {
            if (!IsValid())
                return this;
            
            ResetTimeouts();
            CurrentPeriod = CurrentPeriod.Increment(TotalPeriodsInMatch);
            State = MatchState.PlayInProgress;
            IsBallInPlay = true;
            return this;
        }

        /// <summary>
        /// Starts next period
        /// </summary>
        /// <returns>this</returns>
        public Match EndPeriod()
        {
            if (!IsValid())
                return this;

            IsBallInPlay = false;
            State = MatchState.Interval;

            if (CurrentPeriod == TotalPeriodsInMatch)
                Finish();

            return this;
        }

        /// <summary>
        /// Tracks a timeout requested by specified team
        /// </summary>
        /// <param name="id">Team ID</param>
        /// <returns></returns>
        public Match Timeout(TeamId id)
        {
            if (!IsValid())
                return this;

            // Should we do it?
            if (!CanRequestTimeout(id))
                return this;

            switch (id)
            {
                case TeamId.Home:
                    TimeoutCount1 = TimeoutCount1.Increment(MaxTimeoutsPerPeriod);
                    break;
                case TeamId.Visitors:
                    TimeoutCount2 = TimeoutCount2.Increment(MaxTimeoutsPerPeriod);
                    break;
            }

            IsBallInPlay = false;
            State = MatchState.Timeout;
            return this;
        }

        /// <summary>
        /// Resume match from any sort of interruption by putting the ball in play
        /// </summary>
        /// <returns></returns>
        public Match Resume()
        {
            if (!IsValid())
                return this;

            IsBallInPlay = true;
            State = MatchState.PlayInProgress;
            return this;
        }
        #endregion


        #region Internal

        private void InitializeAsDefault()
        {
            State = MatchState.Unknown;
            CurrentScore = new Score();
            Venue = String.Empty;
            Day = DateTime.Today;
            IsBallInPlay = false;
            CurrentPeriod = 0;
            ResetTimeouts();
        }

        private void ResetTimeouts()
        {
            TimeoutCount1 = 0;
            TimeoutCount2 = 0;
        }
        #endregion
    }
}
