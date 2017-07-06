namespace Module6.EventSourcing.Infrastructure.Framework
{
    public interface IStartWithMessage<in T> where T : Message
    {
        void Handle(T message);
    }
}