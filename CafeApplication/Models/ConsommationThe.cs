using CafeApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Models
{
    public class ConsommationThe : IConsommation
    {
        
        public int ConsommationID { get; set; }
        public string TypeCafe { get; set; }
        public int NombreCuilliere { get; set; }
        public bool PropreMug { get; set; }
        public int ConsomateurID { get; set; }
        public IConsommateur Consomateur { get; set; }

        public int TypeID { get; set; }
        public IType Type { get; set; }
    }
}
