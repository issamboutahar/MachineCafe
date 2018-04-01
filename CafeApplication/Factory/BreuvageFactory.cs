using CafeApplication.Data.Enumeration;
using CafeApplication.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Factory
{
    public static class BreuvageFactory
    {
        public static IBreuvage PreparerBreuvage(int type)
        {
            switch(type)
            {

                case (int)TypeBoisson.Cafe:

                    return new BreuvageCafe();

                case (int)TypeBoisson.Chocolat:

                    return new BreuvageChocolat();

                default:
                    return new BreuvageTea();


            }

        }
    }
}
