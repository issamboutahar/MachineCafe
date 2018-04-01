using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Data.Models
{
    public class Consommateur : BaseEntity
    {
        
       /// <summary>
       /// Le nom du consommateur
       /// </summary>
        public string Nom { get; set; }
        
        /// <summary>
        /// Le prenom du consommateur
        /// </summary>
        public string Prenom { get; set; }
        
        /// <summary>
        /// Derniere selection utilisé par le consommateur
        /// </summary>
        public bool DerniereSelection { get; set; }


        /// <summary>
        /// Collection de consommations
        /// </summary>
        public virtual ICollection<Consommation> Consommations { get; set; }




    }
}
