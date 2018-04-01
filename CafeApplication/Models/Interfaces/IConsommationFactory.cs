using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeApplication.Models.Interfaces
{
    public interface IConsommationFactory
    {
         IConsommation CreerBoisson();
    }
}