namespace Merlo.Eda.Infrastructure
{
    public interface IHandleMessage<in T> where T : Message
    {
        void Handle(T message);
    }
}