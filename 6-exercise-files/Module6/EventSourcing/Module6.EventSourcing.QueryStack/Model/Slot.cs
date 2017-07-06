namespace Module6.EventSourcing.QueryStack.Model
{
    public class Slot
    {
        public Slot()
        {
            Name = "Staff";
            Notes = "[No notes]";
        }

        public int BookingId { get; set; }
        public int StartingAt { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public bool IsAvailable()
        {
            return Length == 0;
        }
    }
}