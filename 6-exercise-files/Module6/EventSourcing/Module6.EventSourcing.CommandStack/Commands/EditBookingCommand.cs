using Module6.EventSourcing.Infrastructure.Framework;

namespace Module6.EventSourcing.CommandStack.Commands
{
    public class EditBookingCommand : Command
    {
        public EditBookingCommand(int bookingId, int hour, string userName, int length)
        {
            Name = "EditBooking";
            BookingId = bookingId;
            Hour = hour;
            UserName = userName;
            Length = length;
        }

        public int BookingId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string UserName { get; private set; } 
    }
}