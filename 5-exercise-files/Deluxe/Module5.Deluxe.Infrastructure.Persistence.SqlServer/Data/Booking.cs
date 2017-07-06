namespace Module5.Deluxe.Infrastructure.Persistence.SqlServer.Data
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string Name { get; set; }
        public int CourtId { get; set; }
        public int StartingAt { get; set; }
        public int Length { get; set; }

        public virtual Court Court { get; set; }
    }
}
