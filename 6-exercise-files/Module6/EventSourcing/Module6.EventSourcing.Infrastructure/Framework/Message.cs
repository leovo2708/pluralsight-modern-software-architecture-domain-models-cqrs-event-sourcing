
namespace Module6.EventSourcing.Infrastructure.Framework
{
    public class Message
    {
        public int SagaId { get; protected set; }
        public string Name { get; protected set; }
    }
}