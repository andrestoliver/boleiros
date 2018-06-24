using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class PerfilUsuarioConfig : IEntityTypeConfiguration<PerfilUsuario>
    {
        public void Configure(EntityTypeBuilder<PerfilUsuario> builder)
        {
            #region Constraints
            builder.ToTable("TB_PERFIL_USUARIO");

            builder.HasOne(p => p.Bolao)
                   .WithMany(p => p.PerfisUsuario)
                   .HasForeignKey(p => p.IdBolao);

            builder.HasOne(p => p.Usuario)
                   .WithMany(p => p.PerfisUsuario)
                   .HasForeignKey(p => p.IdUsuario);

            builder.HasOne(p => p.TipoPerfil)
                   .WithMany(p => p.PerfilUsuarios)
                   .HasForeignKey("ID_TIPO_PERFIL");
            #endregion

            #region Properties
            builder.Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
            builder.Property(p => p.IdBolao).HasColumnName("ID_BOLAO");
            #endregion
        }
    }
}
