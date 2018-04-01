using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeApplication.Data.Models
{
    public class ConsommationMap
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="entityBuilder"></param>
        public ConsommationMap(EntityTypeBuilder<Consommation> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.TypeBoisson);
            entityBuilder.Property(t => t.NombreCuilliere).IsRequired();
            entityBuilder.Property(t => t.PropreMug).IsRequired();
            entityBuilder.HasOne(e => e.Consomateur).WithMany(e => e.Consommations).HasForeignKey(e => e.ConsommateurID);

        }
    }
}
