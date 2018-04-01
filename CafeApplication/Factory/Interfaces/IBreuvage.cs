using CafeApplication.Data.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Factory.Interfaces
{
    public interface IBreuvage
    {
        string Nom { get; set; }
        int TypeBreuvage { get; set; }

        int NombreSucre { get; set; }

        bool PropreMug { get; set; }
    }
}
