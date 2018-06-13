using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boleiros.Infra.Data.Context
{
    public class BoleirosContext : DbContext
    {
        public BoleirosContext(DbContextOptions options) : base(options)
        { }


    }
}
