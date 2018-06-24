using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class TimeConfig : IEntityTypeConfiguration<Time>
    {
        public void Configure(EntityTypeBuilder<Time> builder)
        {
            #region Constraints
            builder.ToTable("TB_TIME");

            builder.HasMany(p => p.JogosMandante)
                   .WithOne(p => p.Mandante)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.JogosVisitante)
                   .WithOne(p => p.Visitante)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Properties
            builder.Property(p => p.Id).HasColumnName("ID_TIME");
            builder.Property(p => p.Nome).HasColumnName("NM_TIME");
            builder.Property(p => p.Sigla).HasColumnName("NM_SIGLA");
            builder.Property(p => p.Descricao).HasColumnName("DE_TIME");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            #endregion
        }
    }
}
