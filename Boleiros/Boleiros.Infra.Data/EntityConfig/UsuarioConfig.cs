using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            #region Constraints
            builder.ToTable("TB_USUARIO");

            builder.HasMany(p => p.PerfisUsuario)
                   .WithOne(p => p.Usuario)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Palpites)
                   .WithOne(p => p.Usuario)
                   .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Properties
            builder.Property(p => p.Id).HasColumnName("ID_USUARIO");
            builder.Property(p => p.Nome).HasColumnName("NM_USUARIO");
            #endregion
        }
    }
}
