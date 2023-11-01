﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalks.Persistence.DatabaseContext;

#nullable disable

namespace NZWalks.Persistence.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    partial class NZWalksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalks.Domain.DifficultyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d80d353-e9df-44c9-bbc8-3c23875d65db"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("4e924955-31ad-4e52-a6ec-e92197f8801a"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("428135c4-815c-4957-9042-a519b8adc4b3"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZWalks.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("NZWalks.Domain.RegionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("661098d8-3e56-4e7b-a5fa-e279d7bcc72d"),
                            Code = "NTL",
                            Name = "Northland",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9d/NorthlandRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("dd68cf7c-4811-44b5-b753-2a6dbc0ad22d"),
                            Code = "AUK",
                            Name = "Auckland",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Auckland_Region#/media/File:Auckland.arp.750pix.jpg"
                        },
                        new
                        {
                            Id = new Guid("c941fc11-ca82-4487-91d5-0c6707a31034"),
                            Code = "WKO",
                            Name = "Waikato",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Waikato#/media/File:NZTerritorialAuthorities-Waikato.png"
                        },
                        new
                        {
                            Id = new Guid("3f9f6091-54f3-4771-9249-6e30738d3181"),
                            Code = "BOP",
                            Name = "Bay of Plenty",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Bay_of_Plenty_Region#/media/File:BayOfPlentyRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("2c42dc59-83e6-4316-acb5-11399adbb71b"),
                            Code = "GIS",
                            Name = "Gisborne",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Gisborne_District#/media/File:GisborneRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("dd2a524c-14a6-4804-bd1c-05e8529bae7c"),
                            Code = "HKB",
                            Name = "Hawke's Bay",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Hawke%27s_Bay#/media/File:HawkesBayRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("ad726936-6b1b-45f0-b799-0dfd94736d6c"),
                            Code = "TKI",
                            Name = "Taranaki",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Taranaki#/media/File:TaranakiRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("a82f00c8-e4be-4225-b005-9591438bd854"),
                            Code = "MWT",
                            Name = "Manawatū-Whanganui",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Manawat%C5%AB-Whanganui#/media/File:ManawatuWanganuiRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("0313863e-057a-494e-87a2-a1d6770041da"),
                            Code = "WGN",
                            Name = "Wellington",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Wellington_Region#/media/File:WellingtonRegionPopulationDensity.png"
                        },
                        new
                        {
                            Id = new Guid("63fb2274-0913-4dfa-ab36-0c4a8be790c8"),
                            Code = "TAS",
                            Name = "Tasman",
                            RegionImageUrl = "https://en.wikipedia.org/wiki/Tasman_District#/media/File:TasmanNelsonRegionPopulationDensity.png"
                        });
                });

            modelBuilder.Entity("NZWalks.Domain.WalkEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZWalks.Domain.WalkEntity", b =>
                {
                    b.HasOne("NZWalks.Domain.DifficultyEntity", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalks.Domain.RegionEntity", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
