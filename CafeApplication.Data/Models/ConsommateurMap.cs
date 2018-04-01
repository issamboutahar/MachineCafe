using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeApplication.Data.Models
{
    public class ConsommateurMap
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="entityBuilder"></param>
        public ConsommateurMap(EntityTypeBuilder<Consommateur> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Nom).IsRequired();
            entityBuilder.Property(t => t.Prenom).IsRequired();
            entityBuilder.Property(t => t.DerniereSelection).IsRequired();
            
        }
    }
}
