namespace Module5.Premium.Shared
{
    // Copy of the same code used in the Command stack
    public enum MatchState
    {
        Unknown = 0,
        ToBePlayed = 1,
        Warmup = 10,
        PlayInProgress = 11,
        Interval = 12,
        Timeout = 13,
        Finished = 20,
    }
}