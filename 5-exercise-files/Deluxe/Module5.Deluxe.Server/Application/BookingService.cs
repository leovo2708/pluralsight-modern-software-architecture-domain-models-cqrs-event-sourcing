using Module5.Deluxe.CommandStack.Commands;

namespace Module5.Deluxe.Server.Application
{
    public class BookingService
    {
        public void AddBooking(int courtId, int hour, int length, string name)
        {
            // Place the command to the bus
            var command = new RequestBookingCommand(
                courtId,
                hour,
                length,
                name
                );
            BookingApplication.Bus.Send(command);
        }
    }
}