namespace Module5.Premium.Command.Model
{
    public enum EventType
    {
        Unknown = 0,
        Created = 1,
        Start = 100,
        End = 101,
        NewPeriod = 200,
        EndPeriod = 201,
        Goal1 = 301,
        Goal2 = 302,
        Timeout1 = 401,
        Timeout2 = 402,
        Resume = 403,
        Undo = 9999
    }
}