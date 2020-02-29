using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interview
{
    public class MemoryRepository<T, I> : IRepository<T, I> where T: IStoreable<I>  
    {
        public readonly List<T> StoreList;

       
        public MemoryRepository()
        {
            if (StoreList == null)
            {
                StoreList = new List<T>();
            }
        }
        public void Delete(I id)
        {
            try
            {
                StoreList.Remove(Get(id));
            
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
            
               
            
        }

        public T Get(I id)
        {
            try
            {
                return StoreList.FirstOrDefault(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return StoreList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void Save(T item)
        {
            try
            {
                StoreList.Add(item);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        


    }
}
