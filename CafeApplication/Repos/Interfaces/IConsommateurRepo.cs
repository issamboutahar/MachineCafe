using CafeApplication.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Repos.Interfaces
{
    public interface IConsommateurRepo : IRepository<IConsommateur, int>
    {
    }
}
