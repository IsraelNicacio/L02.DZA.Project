﻿// <auto-generated />
using System;
using DZA.Cadastro.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DZA.Cadastro.Infrastructure.Data.Migrations
{
    [DbContext(typeof(CadastroContext))]
    partial class CadastroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DZA.Cadastro.Domain.Entities.Departamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos", (string)null);
                });

            modelBuilder.Entity("DZA.Cadastro.Domain.Entities.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Idade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Pessoas", (string)null);
                });

            modelBuilder.Entity("DZA.Cadastro.Domain.Entities.Pessoa", b =>
                {
                    b.HasOne("DZA.Cadastro.Domain.Entities.Departamento", "Departamento")
                        .WithMany("Pessoas")
                        .HasForeignKey("DepartamentoId");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("DZA.Cadastro.Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
