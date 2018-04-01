using CafeApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CafeApplication.Models
{
    public class Type : IType
    {

        
        public int TypeID { get; set; }
        public string Nom { get; set; }
        public int PrixUnitaire { get; set; }
    }
}