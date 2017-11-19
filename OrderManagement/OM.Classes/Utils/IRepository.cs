using System.Linq;

namespace OM.Classes.Utils
{
    public interface IRepository<T>
    {
        T Add(T item);
        T Remove(T item);
        IQueryable<T> GetAll();
    }
}
