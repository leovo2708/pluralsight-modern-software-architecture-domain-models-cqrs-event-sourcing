namespace Merlo.Eda.Infrastructure
{
    public enum EventType
    {
        Unknown = 0,
        Created = 1,
        Start = 2,
        End = 3,
        Period = 4,
        EndPeriod = 5,
        Goal = 6,
        Timeout = 7,
        Resume = 8
    }
}