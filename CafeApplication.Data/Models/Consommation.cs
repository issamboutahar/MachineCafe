using CafeApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Data.Models
{
    public class Consommation : BaseEntity
    {

        /// <summary>
        /// L<identifiant du consommateur
        /// </summary>
        public Int64 ConsommateurID { get; set; }

        /// <summary>
        /// Le type de boisson
        /// </summary>
        public int TypeBoisson { get; set; }

        /// <summary>
        /// Nombre de cuillere de sucre
        /// </summary>
        public int NombreCuilliere { get; set; }

        /// <summary>
        /// L'utilisation du propre Mug
        /// </summary>
        public bool PropreMug { get; set; }

        /// <summary>
        /// L'objet consommateur de la consommation
        /// </summary>
        public virtual Consommateur Consomateur { get; set; }

        
    }
}
