using Boleiros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.EntityConfig
{
    public class CampeonatoConfig : IEntityTypeConfiguration<Bolao>
    {
        public void Configure(EntityTypeBuilder<Bolao> builder)
        {
            throw new NotImplementedException();
        }
    }
}
