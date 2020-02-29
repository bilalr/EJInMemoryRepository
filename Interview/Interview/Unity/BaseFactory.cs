using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    /// <summary>
    /// Base Factory implementation 
    /// </summary>
    /// <typeparam name="J"></typeparam>

    public class BaseFactory<J>
    {
        public static J Create<T, I>() where T : IStoreable<I>
        {
            try
            {
                return UnityManager<T, I>.ResolveDefault<J>();
            }
            catch (Exception ex)
            {
                return UnityManager<T, I>.ResolveDefault<J>();
            }
        }
    }
}
