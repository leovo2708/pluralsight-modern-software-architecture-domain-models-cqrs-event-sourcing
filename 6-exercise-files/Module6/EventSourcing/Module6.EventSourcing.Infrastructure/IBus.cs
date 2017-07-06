namespace Merlo.Eda.Infrastructure
{
    public interface IBus
    {
        void Send<T>(T command) where T : Command;

        void RaiseEvent<T>(T theEvent) where T : EventBase;

        void RegisterSaga<T>() where T : Saga;

        void RegisterHandler<T>();
    }
}