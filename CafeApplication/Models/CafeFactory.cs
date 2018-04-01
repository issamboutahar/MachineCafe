using CafeApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeApplication.Models
{
    public class CafeFactory : IConsommationFactory
    {
        public IConsommation CreerBoisson()
        {
            throw new NotImplementedException();
        }
    }
}