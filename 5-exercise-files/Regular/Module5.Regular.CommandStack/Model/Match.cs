namespace Module5.Regular.CommandStack.Model
{
    public class Match
    {
        public Match()
        {
            Timeouts1 = "0/1";
            Timeouts2 = "0/1";
        }
        public string Id { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int State { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Period { get; set; }
        public string Timeouts1 { get; set; }
        public string Timeouts2 { get; set; }
    }
}
