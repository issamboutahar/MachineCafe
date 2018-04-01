using CafeApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CafeApplication.Models
{
    public class Consomateur : IConsommateur
    {
        
        public int ConsomateurID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool DerniereSelection { get; set; }
    }
}