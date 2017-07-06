using Module6.EventSourcing.CommandStack.Domain.Common;

namespace Module6.EventSourcing.Infrastructure.Framework.Repositories
{
    public interface IRepository
    {
        //TEntity Get(TKey id);
        //void Save(TEntity entity);
        //void Delete(TEntity entity);

        T GetById<T>(int id) where T : IAggregate;

        CommandResponse CreateBookingFromRequest<T>(T item) where T : class, IAggregate;
        CommandResponse Update(int bookingId, int hour, int length, string name);

    }
}