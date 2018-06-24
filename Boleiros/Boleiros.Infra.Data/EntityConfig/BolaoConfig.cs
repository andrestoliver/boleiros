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
                   .HasForeignKey("ID_CAMPEONATO");

            builder.HasMany(p => p.PerfisUsuario)
                   .WithOne(p => p.Bolao);
            #endregion

            #region Propertys
            builder.Property(p => p.Id).HasColumnName("ID_BOLAO");
            builder.Property(p => p.Nome).HasColumnName("NM_BOLAO");
            builder.Property(p => p.Descricao).HasColumnName("DE_BOLAO");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            builder.Property("ID_CAMPEONATO").HasColumnName("ID_CAMPEONATO");
            #endregion
        }
    }
}
