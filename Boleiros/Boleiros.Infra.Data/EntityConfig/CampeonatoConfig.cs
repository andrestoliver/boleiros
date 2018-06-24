using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class CampeonatoConfig : IEntityTypeConfiguration<Campeonato>
    {
        public void Configure(EntityTypeBuilder<Campeonato> builder)
        {
            #region Constraints
            builder.ToTable("TB_CAMPEONATO");
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.Boloes)
                   .WithOne(p => p.Campeonato)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Boloes)
                   .WithOne(p => p.Campeonato)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Properties
            builder.Property(p => p.Id).HasColumnName("ID_CAMPENATO");
            builder.Property(p => p.Nome).HasColumnName("NM_CAMPENATO");
            builder.Property(p => p.Descricao).HasColumnName("DE_CAMPENATO");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            #endregion
        }
    }
}
