using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class PalpiteConfig : IEntityTypeConfiguration<Palpite>
    {
        public void Configure(EntityTypeBuilder<Palpite> builder)
        {
            #region Constraints
            builder.ToTable("TB_PALPITE");
            builder.HasKey(p => new { p.IdJogo, p.IdUsuario });

            builder.HasOne(p => p.Jogo)
                   .WithMany(p => p.Palpites)
                   .HasForeignKey(p => p.IdJogo);

            builder.HasOne(p => p.Usuario)
                   .WithMany(p => p.Palpites)
                   .HasForeignKey(p => p.IdUsuario);
            #endregion

            #region Propertys
            builder.Property(p => p.NumeroGolMandante).HasColumnName("NU_GOL_MANDANTE");
            builder.Property(p => p.NumeroGolVisitante).HasColumnName("NU_GOL_VISITANTE");
            builder.Property(p => p.IdJogo).HasColumnName("ID_JOGO");
            builder.Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            #endregion
        }
    }
}
