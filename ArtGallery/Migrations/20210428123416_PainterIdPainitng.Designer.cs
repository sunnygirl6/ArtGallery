﻿// <auto-generated />
using System;
using ArtGallery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGallery.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210428123416_PainterIdPainitng")]
    partial class PainterIdPainitng
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtGallery.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ArtGallery.Models.ArtMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("ArtMovements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Постимпрессионизм"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Модернизм в изобразительном искусстве"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Романтизм"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Модерн"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Символизм"
                        });
                });

            modelBuilder.Entity("ArtGallery.Models.Painter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeathPlace")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FathersName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Painters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 37,
                            BirthDate = new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthPlace = "Грот-Зюндерт",
                            Country = "Нидерланды",
                            DeathDate = new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathPlace = "Овер-сюр-Уаз",
                            FirstName = "Винсент",
                            LastName = "Ван Гог"
                        },
                        new
                        {
                            Id = 2,
                            Age = 55,
                            BirthDate = new DateTime(1862, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthPlace = "Вена",
                            Country = "Австрийская империя",
                            DeathDate = new DateTime(1918, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathPlace = "Вена",
                            FirstName = "Густав",
                            LastName = "Климт"
                        },
                        new
                        {
                            Id = 3,
                            Age = 82,
                            BirthDate = new DateTime(1817, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthPlace = "Феодосия, Таврическая губерния, Российская империя",
                            Country = "Российская империя",
                            DeathDate = new DateTime(1900, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathPlace = "	Феодосия, Таврическая губерния, Российская империя",
                            FathersName = "Константинович",
                            FirstName = "Иван",
                            LastName = "Айвазовский"
                        });
                });

            modelBuilder.Entity("ArtGallery.Models.Painting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medium")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PainterId")
                        .HasColumnType("int");

                    b.Property<double?>("Size_x")
                        .HasColumnType("float");

                    b.Property<double?>("Size_y")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PainterId");

                    b.ToTable("Paintings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Medium = "Холст, масло",
                            Name = "Звездная ночь",
                            PainterId = 1,
                            Size_x = 73.700000000000003,
                            Size_y = 92.099999999999994,
                            Year = 1889
                        },
                        new
                        {
                            Id = 2,
                            Medium = "Холст, масло",
                            Name = "Цветущие ветки миндаля",
                            PainterId = 1,
                            Size_x = 73.5,
                            Size_y = 92.0,
                            Year = 1890
                        },
                        new
                        {
                            Id = 3,
                            Medium = "Холст, масло",
                            Name = "Девятый вал",
                            PainterId = 3,
                            Size_x = 221.0,
                            Size_y = 332.0,
                            Year = 1850
                        },
                        new
                        {
                            Id = 4,
                            Medium = "Холст, масло",
                            Name = "Поцелуй",
                            PainterId = 2,
                            Size_x = 180.0,
                            Size_y = 180.0,
                            Year = 1908
                        });
                });

            modelBuilder.Entity("ArtMovementPainting", b =>
                {
                    b.Property<int>("ArtMovementsId")
                        .HasColumnType("int");

                    b.Property<int>("PaintingsId")
                        .HasColumnType("int");

                    b.HasKey("ArtMovementsId", "PaintingsId");

                    b.HasIndex("PaintingsId");

                    b.ToTable("ArtMovementPainting");
                });

            modelBuilder.Entity("ArtGallery.Models.Painting", b =>
                {
                    b.HasOne("ArtGallery.Models.Painter", "Painter")
                        .WithMany()
                        .HasForeignKey("PainterId");

                    b.Navigation("Painter");
                });

            modelBuilder.Entity("ArtMovementPainting", b =>
                {
                    b.HasOne("ArtGallery.Models.ArtMovement", null)
                        .WithMany()
                        .HasForeignKey("ArtMovementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtGallery.Models.Painting", null)
                        .WithMany()
                        .HasForeignKey("PaintingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
