namespace Module6.EventSourcing.Infrastructure.Framework
{
    public interface IHandleMessage<in T>
    {
        void Handle(T message);
    }
}