using System.Collections.Generic;
using System.Linq;

namespace OM.Classes.Utils
{
    public class TestRepository<T> : IRepository<T>
    {
        public TestRepository(List<T> list)
        {
            _list = list;
            _listNew = new List<T>(list);
        }

        public TestRepository()
            : this(new List<T>())
        {
        }

        private readonly List<T> _list;
        private readonly List<T> _listNew;

        public T Add(T obj)
        {
            _listNew.Add(obj);
            return obj;
        }

        public T Remove(T obj)
        {
            _listNew.Remove(obj);
            return obj;
        }

        public IQueryable<T> GetAll()
        {
            return GetList().AsQueryable();
        }

        public List<T> GetList()
        {
            return _list.ToArray().ToList();
        }

        public void SaveChanges()
        {
            lock (this)
            {
                _list.Clear();
                _list.AddRange(_listNew);
            }
        }
    }
}