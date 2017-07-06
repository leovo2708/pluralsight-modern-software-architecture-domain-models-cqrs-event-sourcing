namespace Merlo.Eda.Infrastructure
{
    public interface IStartWithMessage<in T> where T : Message
    {
        void Handle(T message);
    }
}