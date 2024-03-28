﻿// <auto-generated />
using System;
using KintelaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KintelaData.Migrations
{
    [DbContext(typeof(KintelaContext))]
    [Migration("20240328120537_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoriaReceta", b =>
                {
                    b.Property<int>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<int>("RecetasId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasId", "RecetasId");

                    b.HasIndex("RecetasId");

                    b.ToTable("CategoriaReceta");
                });

            modelBuilder.Entity("KintelaDomain.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("KintelaDomain.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("KintelaDomain.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Comensales")
                        .HasColumnType("int");

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enlaceVideo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("MenuReceta", b =>
                {
                    b.Property<int>("MenusId")
                        .HasColumnType("int");

                    b.Property<int>("RecetasId")
                        .HasColumnType("int");

                    b.HasKey("MenusId", "RecetasId");

                    b.HasIndex("RecetasId");

                    b.ToTable("MenuReceta");
                });

            modelBuilder.Entity("CategoriaReceta", b =>
                {
                    b.HasOne("KintelaDomain.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KintelaDomain.Receta", null)
                        .WithMany()
                        .HasForeignKey("RecetasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MenuReceta", b =>
                {
                    b.HasOne("KintelaDomain.Menu", null)
                        .WithMany()
                        .HasForeignKey("MenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KintelaDomain.Receta", null)
                        .WithMany()
                        .HasForeignKey("RecetasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
