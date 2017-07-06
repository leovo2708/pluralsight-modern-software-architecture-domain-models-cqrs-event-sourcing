namespace Module5.Deluxe.Infrastructure.Framework
{
    public interface IBus
    {
        void Send<T>(T command) where T : Command;

        void RaiseEvent<T>(T theEvent) where T : Event;

        void RegisterSaga<T>() where T : Saga;

        void RegisterHandler<T>();
    }
}