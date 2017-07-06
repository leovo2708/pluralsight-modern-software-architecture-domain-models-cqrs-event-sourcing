namespace Module5.Deluxe.QueryStack.Model
{
    public class Slot
    {
        public Slot()
        {
            Name = "Staff";
        }

        public int BookingId { get; set; }
        public int StartingAt { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }

        public bool IsAvailable()
        {
            return Length == 0;
        }
    }
}