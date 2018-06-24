﻿// <auto-generated />
using System;
using Boleiros.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boleiros.Infra.Data.Migrations
{
    [DbContext(typeof(BoleirosContext))]
    [Migration("20180624134219_FK Bolao")]
    partial class FKBolao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Boleiros.Domain.Entities.Bolao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("CampeonatoId");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoId");

                    b.ToTable("Boloes");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Campeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Campeonatos");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("IdMandante");

                    b.Property<int>("IdRodada");

                    b.Property<int>("IdVisitante");

                    b.Property<int>("NumeroGolMandante");

                    b.Property<int>("NumeroGolVisitante");

                    b.Property<int?>("RodadaId");

                    b.HasKey("Id");

                    b.HasIndex("RodadaId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Palpite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("JogoId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("JogoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Palpites");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.PerfilUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BolaoId");

                    b.Property<int?>("TipoPerfilId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("BolaoId");

                    b.HasIndex("TipoPerfilId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PerfisUsuario");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Rodada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("CampeonatoId");

                    b.Property<string>("Descricao");

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoId");

                    b.ToTable("Rodadas");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<string>("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.TipoPerfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TiposPerfil");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Bolao", b =>
                {
                    b.HasOne("Boleiros.Domain.Entities.Campeonato", "Campeonato")
                        .WithMany("Boloes")
                        .HasForeignKey("CampeonatoId");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Jogo", b =>
                {
                    b.HasOne("Boleiros.Domain.Entities.Rodada", "Rodada")
                        .WithMany("Jogos")
                        .HasForeignKey("RodadaId");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Palpite", b =>
                {
                    b.HasOne("Boleiros.Domain.Entities.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoId");

                    b.HasOne("Boleiros.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.PerfilUsuario", b =>
                {
                    b.HasOne("Boleiros.Domain.Entities.Bolao", "Bolao")
                        .WithMany("PerfisUsuario")
                        .HasForeignKey("BolaoId");

                    b.HasOne("Boleiros.Domain.Entities.TipoPerfil")
                        .WithMany("PerfilUsuarios")
                        .HasForeignKey("TipoPerfilId");

                    b.HasOne("Boleiros.Domain.Entities.Usuario", "Usuario")
                        .WithMany("PerfisUsuario")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Boleiros.Domain.Entities.Rodada", b =>
                {
                    b.HasOne("Boleiros.Domain.Entities.Campeonato", "Campeonato")
                        .WithMany("Rodadas")
                        .HasForeignKey("CampeonatoId");
                });
#pragma warning restore 612, 618
        }
    }
}
