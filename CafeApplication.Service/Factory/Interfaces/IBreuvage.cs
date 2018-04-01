using CafeApplication.Service.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Service.Factory.Interfaces
{
    public interface IBreuvage
    {
        /// <summary>
        /// L'identifiant du consommateur
        /// </summary>
        Int64 ConsommateurID { get; set; }

        /// <summary>
        /// Le nom du consommateur
        /// </summary>
        string Nom { get; set; }

        /// <summary>
        /// Le type de boisson  
        /// </summary>
        int TypeBoisson { get; set; }

        /// <summary>
        /// Le nombre de cuillère de sucre
        /// </summary>
        int NombreCuilliere { get; set; }

        /// <summary>
        /// L'utilisation du propre Mug
        /// </summary>
        bool PropreMug { get; set; }

        /// <summary>
        /// La dernière selection utilisé pour un breuvage
        /// </summary>
        bool DerniereSelection { get; set; }


    }
}
