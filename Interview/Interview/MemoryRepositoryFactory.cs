using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{


    public class MemoryRepositoryFactory<T, I> : BaseFactory<IRepository<T, I>> where T : IStoreable<I>
    {
    }
}
