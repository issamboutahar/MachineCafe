using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Factory.Interfaces
{
    public interface IBreuvageFactory
    {
        IBreuvage PreparerBreuvage();
    }
}
