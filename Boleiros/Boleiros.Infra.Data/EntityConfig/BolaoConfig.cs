using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class BolaoConfig : IEntityTypeConfiguration<Bolao>
    {
        public void Configure(EntityTypeBuilder<Bolao> builder)
        {
            #region Constraints
            builder.ToTable("TB_BOLAO");
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Campeonato)
                   .WithMany(p => p.Boloes)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.PerfisUsuario)
                   .WithOne(p => p.Bolao)
                   .HasForeignKey("ID_BOLAO");
            #endregion

            #region Propertys
            builder.Property(p => p.Id).HasColumnName("ID_BOLAO");
            builder.Property(p => p.Nome).HasColumnName("ID_BOLAO");
            #endregion
        }
    }
}
