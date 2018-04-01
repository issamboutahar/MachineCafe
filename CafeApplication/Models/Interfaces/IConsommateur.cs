using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Models.Interfaces
{
    public interface IConsommateur
    {
        
        int ConsomateurID { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
        bool DerniereSelection { get; set; }

        

        
    }
}
