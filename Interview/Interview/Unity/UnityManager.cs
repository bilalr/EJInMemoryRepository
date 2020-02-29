using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Interview
{
    /// <summary>
    /// Dependancy injection implemenations by using Unity
    /// </summary>
    /// <typeparam name="T"> IStroabele<typeparamref name="I"/></typeparam>
    /// <typeparam name="I"></typeparam>
    public class UnityManager<T, I> where T : IStoreable<I>
    {
       
        public static IUnityContainer DefaultContainer { get; set; }

        static UnityManager()
        {
            DefaultContainer = new UnityContainer();
            ConfigureContainers();
        }

        static void ConfigureContainers()
        {
            DefaultContainer.RegisterType<IRepository<T, I>, MemoryRepository<T, I>>();
        }

        public static J ResolveDefault<J>()
        {
            J instance = UnityManager<T, I>.DefaultContainer.Resolve<J>();
            return instance;
        }
    }

}
