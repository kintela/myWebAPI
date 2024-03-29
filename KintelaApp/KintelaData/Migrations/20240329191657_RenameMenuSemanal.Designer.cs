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
    [Migration("20240329191657_RenameMenuSemanal")]
    partial class RenameMenuSemanal
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
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("RecetasRecetaId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "RecetasRecetaId");

                    b.HasIndex("RecetasRecetaId");

                    b.ToTable("CategoriaReceta");
                });

            modelBuilder.Entity("KintelaDomain.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Carne"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Ensalada"
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Huevos"
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Legumbres"
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Pasta"
                        },
                        new
                        {
                            CategoriaId = 6,
                            Nombre = "Patatas"
                        },
                        new
                        {
                            CategoriaId = 7,
                            Nombre = "Pescado"
                        },
                        new
                        {
                            CategoriaId = 8,
                            Nombre = "Postre"
                        },
                        new
                        {
                            CategoriaId = 9,
                            Nombre = "Sandwich"
                        },
                        new
                        {
                            CategoriaId = 10,
                            Nombre = "Sopa"
                        },
                        new
                        {
                            CategoriaId = 11,
                            Nombre = "Tortilla"
                        },
                        new
                        {
                            CategoriaId = 12,
                            Nombre = "Verdura"
                        });
                });

            modelBuilder.Entity("KintelaDomain.Disco", b =>
                {
                    b.Property<int>("DiscoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscoId"));

                    b.Property<string>("Caratula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discografica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Productor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearPublicacion")
                        .HasColumnType("int");

                    b.HasKey("DiscoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("Discos");

                    b.HasData(
                        new
                        {
                            DiscoId = 1,
                            Caratula = "1.jpg",
                            Discografica = "Shelter Records",
                            GrupoId = 3,
                            Nombre = "Tom Petty & The Heartbreakers",
                            Productor = "Denny Cordell",
                            YearPublicacion = 1976
                        },
                        new
                        {
                            DiscoId = 2,
                            Caratula = "2.jpg",
                            Discografica = "Shelter Records",
                            GrupoId = 3,
                            Nombre = "You're Gonna Get It!",
                            Productor = "Denny Cordell, Noah Shark, Tom Petty",
                            YearPublicacion = 1978
                        },
                        new
                        {
                            DiscoId = 3,
                            Caratula = "3.jpg",
                            Discografica = "Backstreet Records",
                            GrupoId = 3,
                            Nombre = "Damn the Torpedoes",
                            Productor = "Jimmy Iovine, Tom Petty",
                            YearPublicacion = 1979
                        },
                        new
                        {
                            DiscoId = 4,
                            Caratula = "4.jpg",
                            Discografica = "Backstreet Records",
                            GrupoId = 3,
                            Nombre = "Hard Promises",
                            Productor = "Jimmy Iovine, Tom Petty",
                            YearPublicacion = 1981
                        },
                        new
                        {
                            DiscoId = 5,
                            Caratula = "5.jpg",
                            Discografica = "Backstreet Records",
                            GrupoId = 3,
                            Nombre = "Long After Dark",
                            Productor = "Jimmy Iovine, Tom Petty",
                            YearPublicacion = 1982
                        },
                        new
                        {
                            DiscoId = 6,
                            Caratula = "6.jpg",
                            Discografica = "MCA Records",
                            GrupoId = 3,
                            Nombre = "Southern Accents",
                            Productor = "Tom Petty, Dave Stewart, Jimmy Iovine, Robbie Robertson, Mike Campbell",
                            YearPublicacion = 1985
                        },
                        new
                        {
                            DiscoId = 7,
                            Caratula = "7.jpg",
                            Discografica = "MCA Records",
                            GrupoId = 3,
                            Nombre = "Let Me Up (I've Had Enough)",
                            Productor = "Tom Petty, Mike Campbell",
                            YearPublicacion = 1987
                        },
                        new
                        {
                            DiscoId = 8,
                            Caratula = "8.jpg",
                            Discografica = "MCA Records",
                            GrupoId = 3,
                            Nombre = "Into the Great Wide Open",
                            Productor = "Jeff Lynne, Tom Petty, Mike Campbell",
                            YearPublicacion = 1991
                        },
                        new
                        {
                            DiscoId = 9,
                            Caratula = "9.jpg",
                            Discografica = "Warner Bros. Records",
                            GrupoId = 3,
                            Nombre = "Songs and Music from 'She's the One'",
                            Productor = "Rick Rubin, Tom Petty, Mike Campbell",
                            YearPublicacion = 1996
                        },
                        new
                        {
                            DiscoId = 10,
                            Caratula = "10.jpg",
                            Discografica = "Warner Bros. Records",
                            GrupoId = 3,
                            Nombre = "Echo",
                            Productor = "Rick Rubin, Tom Petty, Mike Campbell",
                            YearPublicacion = 1999
                        },
                        new
                        {
                            DiscoId = 11,
                            Caratula = "11.jpg",
                            Discografica = "Warner Bros. Records",
                            GrupoId = 3,
                            Nombre = "The Last DJ",
                            Productor = "Tom Petty, Mike Campbell, George Drakoulias",
                            YearPublicacion = 2002
                        },
                        new
                        {
                            DiscoId = 12,
                            Caratula = "12.jpg",
                            Discografica = "Reprise Records",
                            GrupoId = 3,
                            Nombre = "Mojo",
                            Productor = "Tom Petty, Mike Campbell, Ryan Ulyate",
                            YearPublicacion = 2010
                        },
                        new
                        {
                            DiscoId = 13,
                            Caratula = "13.jpg",
                            Discografica = "Reprise Records",
                            GrupoId = 3,
                            Nombre = "Hypnotic Eye",
                            Productor = "Tom Petty, Mike Campbell, Ryan Ulyate",
                            YearPublicacion = 2014
                        },
                        new
                        {
                            DiscoId = 14,
                            Caratula = "14.jpg",
                            Discografica = "Warner Bros. Records",
                            GrupoId = 4,
                            Nombre = "Wildflowers",
                            Productor = "Rick Rubin, Tom Petty, Mike Campbell",
                            YearPublicacion = 1994
                        },
                        new
                        {
                            DiscoId = 15,
                            Caratula = "15.jpg",
                            Discografica = "American Recordings",
                            GrupoId = 4,
                            Nombre = "Highway Companion",
                            Productor = "Jeff Lynne, Tom Petty, Mike Campbell",
                            YearPublicacion = 2006
                        },
                        new
                        {
                            DiscoId = 16,
                            Caratula = "16.jpg",
                            Discografica = "Warner Bros. Records",
                            GrupoId = 5,
                            Nombre = "Traveling Wilburys Vol. 1",
                            Productor = "Jeff Lynne, George Harrison",
                            YearPublicacion = 1998
                        },
                        new
                        {
                            DiscoId = 17,
                            Caratula = "17.jpg",
                            Discografica = "Warner Bros. Records",
                            GrupoId = 5,
                            Nombre = "Traveling Wilburys Vol. 3",
                            Productor = "Jeff Lynne, George Harrison",
                            YearPublicacion = 1998
                        },
                        new
                        {
                            DiscoId = 18,
                            Caratula = "1.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Please Please Me",
                            Productor = "George Martin",
                            YearPublicacion = 1963
                        },
                        new
                        {
                            DiscoId = 19,
                            Caratula = "1.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "With The Beatles",
                            Productor = "George Martin",
                            YearPublicacion = 1963
                        },
                        new
                        {
                            DiscoId = 20,
                            Caratula = "2.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "A Hard Day's Night",
                            Productor = "George Martin",
                            YearPublicacion = 1964
                        },
                        new
                        {
                            DiscoId = 21,
                            Caratula = "3.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Beatles for Sale",
                            Productor = "George Martin",
                            YearPublicacion = 1964
                        },
                        new
                        {
                            DiscoId = 22,
                            Caratula = "4.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Help!",
                            Productor = "George Martin",
                            YearPublicacion = 1965
                        },
                        new
                        {
                            DiscoId = 23,
                            Caratula = "5.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Rubber Soul",
                            Productor = "George Martin",
                            YearPublicacion = 1965
                        },
                        new
                        {
                            DiscoId = 24,
                            Caratula = "6.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Revolver",
                            Productor = "George Martin",
                            YearPublicacion = 1966
                        },
                        new
                        {
                            DiscoId = 25,
                            Caratula = "7.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Sgt. Pepper's Lonely Hearts Club Band",
                            Productor = "George Martin",
                            YearPublicacion = 1967
                        },
                        new
                        {
                            DiscoId = 26,
                            Caratula = "8.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Magical Mystery Tour",
                            Productor = "George Martin",
                            YearPublicacion = 1967
                        },
                        new
                        {
                            DiscoId = 27,
                            Caratula = "9.png",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "The Beatles (White Album)",
                            Productor = "George Martin",
                            YearPublicacion = 1968
                        },
                        new
                        {
                            DiscoId = 28,
                            Caratula = "10.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Yellow Submarine",
                            Productor = "George Martin",
                            YearPublicacion = 1969
                        },
                        new
                        {
                            DiscoId = 29,
                            Caratula = "11.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Abbey Road",
                            Productor = "George Martin",
                            YearPublicacion = 1969
                        },
                        new
                        {
                            DiscoId = 30,
                            Caratula = "12.jpeg",
                            Discografica = "Parlophone",
                            GrupoId = 1,
                            Nombre = "Let It Be",
                            Productor = "George Martin",
                            YearPublicacion = 1970
                        },
                        new
                        {
                            DiscoId = 31,
                            Caratula = "31.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "The Rolling Stones",
                            Productor = "Andrew Loog Oldham",
                            YearPublicacion = 1964
                        },
                        new
                        {
                            DiscoId = 32,
                            Caratula = "32.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "The Rolling Stones No. 2",
                            Productor = "Andrew Loog Oldham",
                            YearPublicacion = 1965
                        },
                        new
                        {
                            DiscoId = 33,
                            Caratula = "33.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "Out of Our Heads",
                            Productor = "Andrew Loog Oldham",
                            YearPublicacion = 1965
                        },
                        new
                        {
                            DiscoId = 34,
                            Caratula = "34.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "Aftermath",
                            Productor = "Andrew Loog Oldham",
                            YearPublicacion = 1966
                        },
                        new
                        {
                            DiscoId = 35,
                            Caratula = "35.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "Between the Buttons",
                            Productor = "Andrew Loog Oldham",
                            YearPublicacion = 1967
                        },
                        new
                        {
                            DiscoId = 36,
                            Caratula = "36.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "Their Satanic Majesties Request",
                            Productor = "The Rolling Stones",
                            YearPublicacion = 1967
                        },
                        new
                        {
                            DiscoId = 37,
                            Caratula = "37.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "Beggar's Banquet",
                            Productor = "Jimmy Miller",
                            YearPublicacion = 1968
                        },
                        new
                        {
                            DiscoId = 38,
                            Caratula = "38.jpeg",
                            Discografica = "Decca Records",
                            GrupoId = 2,
                            Nombre = "Let It Bleed",
                            Productor = "Jimmy Miller",
                            YearPublicacion = 1969
                        },
                        new
                        {
                            DiscoId = 39,
                            Caratula = "39.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Sticky Fingers",
                            Productor = "Jimmy Miller",
                            YearPublicacion = 1971
                        },
                        new
                        {
                            DiscoId = 40,
                            Caratula = "40.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Exile on Main St",
                            Productor = "Jimmy Miller",
                            YearPublicacion = 1972
                        },
                        new
                        {
                            DiscoId = 41,
                            Caratula = "41.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Goats Head Soup",
                            Productor = "Jimmy Miller",
                            YearPublicacion = 1973
                        },
                        new
                        {
                            DiscoId = 42,
                            Caratula = "42.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "It's Only Rock 'n Roll",
                            Productor = "The Glimmer Twins",
                            YearPublicacion = 1974
                        },
                        new
                        {
                            DiscoId = 43,
                            Caratula = "43.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Black and Blue",
                            Productor = "The Glimmer Twins",
                            YearPublicacion = 1976
                        },
                        new
                        {
                            DiscoId = 44,
                            Caratula = "43.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Some Girls",
                            Productor = "The Glimmer Twins",
                            YearPublicacion = 1978
                        },
                        new
                        {
                            DiscoId = 45,
                            Caratula = "44.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Emotional Rescue",
                            Productor = "The Glimmer Twins",
                            YearPublicacion = 1980
                        },
                        new
                        {
                            DiscoId = 46,
                            Caratula = "45.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Tatoo You",
                            Productor = "The Glimmer Twins",
                            YearPublicacion = 1981
                        },
                        new
                        {
                            DiscoId = 47,
                            Caratula = "46.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Undercover",
                            Productor = "The Glimmer Twins, Chris Kimsey",
                            YearPublicacion = 1983
                        },
                        new
                        {
                            DiscoId = 48,
                            Caratula = "47.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Dirty Work",
                            Productor = "The Glimmer Twins, Steve Lilywhite",
                            YearPublicacion = 1986
                        },
                        new
                        {
                            DiscoId = 49,
                            Caratula = "48.jpeg",
                            Discografica = "Rolling Stones Records",
                            GrupoId = 2,
                            Nombre = "Steel Wheels",
                            Productor = "The Glimmer Twins, Chris Kimsey",
                            YearPublicacion = 1989
                        },
                        new
                        {
                            DiscoId = 50,
                            Caratula = "49.jpeg",
                            Discografica = "Virgin Records",
                            GrupoId = 2,
                            Nombre = "Voodoo Lounge",
                            Productor = "The Glimmer Twins, Don Was",
                            YearPublicacion = 1994
                        },
                        new
                        {
                            DiscoId = 51,
                            Caratula = "50.jpeg",
                            Discografica = "Virgin Records",
                            GrupoId = 2,
                            Nombre = "Bridge to Babylon",
                            Productor = "The Glimmer Twins. Don Was, Rob Fraboni, Danny Saber, Pierre de Beauport. The Dust Brothers",
                            YearPublicacion = 1997
                        },
                        new
                        {
                            DiscoId = 52,
                            Caratula = "51.jpeg",
                            Discografica = "Virgin Records",
                            GrupoId = 2,
                            Nombre = "A Bigger Bang",
                            Productor = "The Glimmer Twins, Don Was, Matt Clifford",
                            YearPublicacion = 2005
                        },
                        new
                        {
                            DiscoId = 53,
                            Caratula = "52.jpeg",
                            Discografica = "Polydor Records",
                            GrupoId = 2,
                            Nombre = "Blue & Lonesome",
                            Productor = "The Glimmer Twins, Don Was",
                            YearPublicacion = 2016
                        },
                        new
                        {
                            DiscoId = 54,
                            Caratula = "53.jpeg",
                            Discografica = "Geffen Records",
                            GrupoId = 2,
                            Nombre = "Hackney Diamonds",
                            Productor = "Andrew Watt",
                            YearPublicacion = 2023
                        });
                });

            modelBuilder.Entity("KintelaDomain.Grupo", b =>
                {
                    b.Property<int>("GrupoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GrupoId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrupoId");

                    b.ToTable("Grupos");

                    b.HasData(
                        new
                        {
                            GrupoId = 1,
                            Nombre = "The Beatles"
                        },
                        new
                        {
                            GrupoId = 2,
                            Nombre = "The Rolling Stones"
                        },
                        new
                        {
                            GrupoId = 3,
                            Nombre = "Tom Petty & The Heart Breakers"
                        },
                        new
                        {
                            GrupoId = 4,
                            Nombre = "Tom Petty"
                        },
                        new
                        {
                            GrupoId = 5,
                            Nombre = "Traveling Wilburys"
                        });
                });

            modelBuilder.Entity("KintelaDomain.MenuSemanal", b =>
                {
                    b.Property<int>("MenuSemanalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuSemanalId"));

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<int?>("RecetaPostreDomingo")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPostreJueves")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPostreLunes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPostreMartes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPostreMiercoles")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPostreSabado")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPostreViernes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoDomingo")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoJueves")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoLunes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoMartes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoMiercoles")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoSabado")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaPrimerPlatoViernes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoDomingo")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoJueves")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoLunes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoMartes")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoMiercoles")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoSabado")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaSegundoPlatoViernes")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("MenuSemanalId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("MenuSemanal");
                });

            modelBuilder.Entity("KintelaDomain.Receta", b =>
                {
                    b.Property<int>("RecetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecetaId"));

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

                    b.HasKey("RecetaId");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("KintelaDomain.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MenuSemanalReceta", b =>
                {
                    b.Property<int>("MenuSemanalId")
                        .HasColumnType("int");

                    b.Property<int>("RecetasRecetaId")
                        .HasColumnType("int");

                    b.HasKey("MenuSemanalId", "RecetasRecetaId");

                    b.HasIndex("RecetasRecetaId");

                    b.ToTable("MenuSemanalReceta");
                });

            modelBuilder.Entity("CategoriaReceta", b =>
                {
                    b.HasOne("KintelaDomain.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KintelaDomain.Receta", null)
                        .WithMany()
                        .HasForeignKey("RecetasRecetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KintelaDomain.Disco", b =>
                {
                    b.HasOne("KintelaDomain.Grupo", "Grupo")
                        .WithMany("Discos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("KintelaDomain.MenuSemanal", b =>
                {
                    b.HasOne("KintelaDomain.Usuario", "Usuario")
                        .WithMany("Menus")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MenuSemanalReceta", b =>
                {
                    b.HasOne("KintelaDomain.MenuSemanal", null)
                        .WithMany()
                        .HasForeignKey("MenuSemanalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KintelaDomain.Receta", null)
                        .WithMany()
                        .HasForeignKey("RecetasRecetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KintelaDomain.Grupo", b =>
                {
                    b.Navigation("Discos");
                });

            modelBuilder.Entity("KintelaDomain.Usuario", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
