using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class RodadaConfig : IEntityTypeConfiguration<Rodada>
    {
        public void Configure(EntityTypeBuilder<Rodada> builder)
        {
            #region Constraints
            builder.ToTable("TB_RODADA");
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Campeonato)
                   .WithMany(p => p.Rodadas)
                   .HasForeignKey("ID_CAMPEONATO");

            builder.HasMany(p => p.Jogos)
                   .WithOne(p => p.Rodada)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Properties
            builder.Property(p => p.Id).HasColumnName("ID_RODADA");
            builder.Property(p => p.Numero).HasColumnName("NU_RODADA");
            builder.Property(p => p.Descricao).HasColumnName("DE_RODADA");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            #endregion
        }
    }
}
