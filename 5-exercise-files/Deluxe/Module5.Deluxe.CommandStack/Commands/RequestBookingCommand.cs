using Module5.Deluxe.Infrastructure.Framework;

namespace Module5.Deluxe.CommandStack.Commands
{
    public class RequestBookingCommand : Command
    {
        public RequestBookingCommand(int courtId, int hour, int length, string userName)
        {
            Name = "AddBooking";
            CourtId = courtId;
            Hour = hour;
            Length = length;
            UserName = userName;
        }

        public int CourtId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string UserName { get; private set; }
    }
}