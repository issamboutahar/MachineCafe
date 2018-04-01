using CafeApplication.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Factory
{
    public class BreuvageTea : IBreuvage
    {
        public string Nom { get; set; }
        public int TypeBreuvage { get; set; }
        public int NombreSucre { get; set; }

        public bool PropreMug { get; set; }

        
    }
}
