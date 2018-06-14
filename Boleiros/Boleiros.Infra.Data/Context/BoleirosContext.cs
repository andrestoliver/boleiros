using Boleiros.Domain.Entities;
using Boleiros.Infra.Data.EntityConfig;
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

        #region DbSets
        public DbSet<Bolao> Boloes { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Palpite> Palpites { get; set; }
        public DbSet<PerfilUsuario> PerfisUsuario { get; set; }
        public DbSet<Rodada> Rodadas { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<TipoPerfil> TiposPerfil { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        #region Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new BolaoConfig());
        }
        #endregion

    }
}
