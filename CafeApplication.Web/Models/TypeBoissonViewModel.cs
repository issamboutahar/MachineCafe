using CafeApplication.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Web.Models
{
    public class TypeBoissonViewModel 
    {

        [DisplayName("Select Consommateur")]
        public virtual int ConsommateurID { get; set; }

        [DisplayName("Type de Boisson")]
        public virtual TypeBoisson TypeBoisson { get; set; }
        [DisplayName("Nombre de cuillere")]
        public virtual int NombreCuilliere { get; set; }

        [DisplayName("Utilisation de ton Propre Mug")]
        public virtual bool PropreMug { get; set; }

        [DisplayName("Utilisation du Badge")]
        public virtual bool DerniereSelection { get; set; }

    }
}
