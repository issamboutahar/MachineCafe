using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Data.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// L'identifiant de l'objet
        /// </summary>
        public Int64 Id { get; set; }

        /// <summary>
        /// La date de l'ajout de l'objet
        /// </summary>
        public DateTime AddedDate { get; set; }


        /// <summary>
        /// La date de modification de l'objet
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// L'adresse IP
        /// </summary>
        public string IPAddress { get; set; }
    }
}
