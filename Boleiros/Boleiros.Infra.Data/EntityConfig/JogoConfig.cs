using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class JogoConfig : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            #region Constraints
            builder.ToTable("TB_JOGO");
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Rodada)
                   .WithMany(p => p.Jogos)
                   .HasForeignKey("ID_RODADA");

            builder.HasOne(p => p.Visitante)
                   .WithMany(p => p.JogosVisitante)
                   .HasForeignKey("ID_VISITANTE");

            builder.HasOne(p => p.Mandante)
                   .WithMany(p => p.JogosMandante)
                   .HasForeignKey("ID_MANDANTE");

            builder.HasMany(p => p.Palpites)
                   .WithOne(p => p.Jogo)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Propertys
            builder.Property(p => p.Id).HasColumnName("ID_JOGO");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            #endregion
        }
    }
}
