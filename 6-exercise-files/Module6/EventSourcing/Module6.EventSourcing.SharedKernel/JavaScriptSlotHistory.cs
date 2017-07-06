using System.Collections.Generic;

namespace Module6.EventSourcing.SharedKernel
{
    public class JavaScriptSlotHistory
    {
        public int BookingId { get; set; }
        public IList<JavaScriptSlotInfo> ChangeList { get; set; }
    }
}