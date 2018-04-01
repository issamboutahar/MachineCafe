
using CafeApplication.Service.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Service.Factory
{
    public class BreuvageCafe : IBreuvage
    {
        public Int64 ConsommateurID { get; set; }
        public string Nom { get { return "Café"; } set { Nom = value; } }
        
        public int NombreCuilliere { get; set; }

        public bool PropreMug { get; set; }

        public int TypeBoisson { get; set; }
        public bool DerniereSelection { get; set; }


    }
}
