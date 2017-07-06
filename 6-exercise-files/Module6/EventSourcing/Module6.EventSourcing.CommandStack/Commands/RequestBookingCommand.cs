using Module6.EventSourcing.Infrastructure.Framework;

namespace Module6.EventSourcing.CommandStack.Commands
{
    public class RequestBookingCommand : Command
    {
        public RequestBookingCommand(int courtId, int hour, int length, string userName, string notes)
        {
            Name = "AddBooking";
            CourtId = courtId;
            Hour = hour;
            Length = length;
            UserName = userName;
            Notes = notes;
        }

        public int CourtId { get; private set; }
        public int Hour { get; private set; }
        public int Length { get; private set; }
        public string UserName { get; private set; }
        public string Notes { get; private set; }
    }
}