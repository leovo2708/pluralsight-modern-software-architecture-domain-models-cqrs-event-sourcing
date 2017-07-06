using System;

namespace Module6.EventSourcing.SharedKernel
{
    public class SlotInfo
    {
        public string Action { get; set; }
        public int BookingId { get; set; }
        public int StartingAt { get; set; }
        public int CourtId { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime When { get; set; }
    }
}