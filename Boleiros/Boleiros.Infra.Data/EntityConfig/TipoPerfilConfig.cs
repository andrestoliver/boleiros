using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class TipoPerfilConfig : IEntityTypeConfiguration<TipoPerfil>
    {
        public void Configure(EntityTypeBuilder<TipoPerfil> builder)
        {
            #region Constraints
            builder.ToTable("TB_TIPO_PERFIL");

            builder.HasMany(p => p.PerfilUsuarios)
                   .WithOne(p => p.TipoPerfil)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Properties
            builder.Property(p => p.Id).HasColumnName("ID_TIPO_PERFIL");
            builder.Property(p => p.Nome).HasColumnName("NM_TIPO_PERFIL");
            builder.Property(p => p.Descricao).HasColumnName("DE_TIPO_PERFIL");
            builder.Property(p => p.Ativo).HasColumnName("IN_ATIVO");
            #endregion
        }
    }
}
