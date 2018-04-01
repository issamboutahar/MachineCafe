using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Service.Factory.Interfaces
{
    public interface IBreuvageFactory
    {
        /// <summary>
        /// Préparer le breuvage
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        IBreuvage PreparerBreuvage(int i);
    }
}
