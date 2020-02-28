using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Repository<T, I> : IRepository<T, I> where T : IStoreable<I>
    {
        public readonly List<T> StoreList;

       
        public Repository()
        {
            if (StoreList == null)
            {
                StoreList = new List<T>();
            }
        }
        public void Delete(I id)
        {
            StoreList.Remove(Get(id));
        }

        public T Get(I id)
        {
            return StoreList.FirstOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<T> GetAll()
        {
            return StoreList;
        }

        public void Save(T item)
        {
            StoreList.Add(item);
        }
    }
}
