using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Models.Interfaces
{
    public interface IConsommation
    {
        
        int ConsommationID { get; set; }
        string TypeCafe { get; set; }

        int NombreCuilliere { get; set; }

        bool PropreMug { get; set; }

        
    }
}
