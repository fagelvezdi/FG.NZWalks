using Microsoft.EntityFrameworkCore;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Persistence.DatabaseContext
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions)  
        {
            
        }

        public DbSet<DifficultyEntity> Difficulties { get; set; }
        
        public DbSet<RegionEntity> Regions { get; set; }

        public DbSet<WalkEntity> Walks { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            var difficulties = new List<DifficultyEntity>()
            {
                new DifficultyEntity
                {
                    Id = Guid.Parse("6d80d353-e9df-44c9-bbc8-3c23875d65db"),
                    Name = "Easy"
                },
                new DifficultyEntity
                {
                    Id = Guid.Parse("4e924955-31ad-4e52-a6ec-e92197f8801a"),
                    Name = "Medium"
                },
                new DifficultyEntity
                {
                    Id = Guid.Parse("428135c4-815c-4957-9042-a519b8adc4b3"),
                    Name = "Hard"
                },
            };

            //Seed dificulties to the database
            modelBuilder.Entity<DifficultyEntity>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<RegionEntity>() 
            { 
                new RegionEntity 
                {
                    Id = Guid.Parse("661098d8-3e56-4e7b-a5fa-e279d7bcc72d"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9d/NorthlandRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("dd68cf7c-4811-44b5-b753-2a6dbc0ad22d"),
                    Name = "Auckland",
                    Code = "AUK",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Auckland_Region#/media/File:Auckland.arp.750pix.jpg"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("c941fc11-ca82-4487-91d5-0c6707a31034"),
                    Name = "Waikato",
                    Code = "WKO",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Waikato#/media/File:NZTerritorialAuthorities-Waikato.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("3f9f6091-54f3-4771-9249-6e30738d3181"),
                    Name = "Bay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Bay_of_Plenty_Region#/media/File:BayOfPlentyRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("2c42dc59-83e6-4316-acb5-11399adbb71b"),
                    Name = "Gisborne",
                    Code = "GIS",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Gisborne_District#/media/File:GisborneRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("dd2a524c-14a6-4804-bd1c-05e8529bae7c"),
                    Name = "Hawke's Bay",
                    Code = "HKB",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Hawke%27s_Bay#/media/File:HawkesBayRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("ad726936-6b1b-45f0-b799-0dfd94736d6c"),
                    Name = "Taranaki",
                    Code = "TKI",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Taranaki#/media/File:TaranakiRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("a82f00c8-e4be-4225-b005-9591438bd854"),
                    Name = "Manawatū-Whanganui",
                    Code = "MWT",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Manawat%C5%AB-Whanganui#/media/File:ManawatuWanganuiRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("0313863e-057a-494e-87a2-a1d6770041da"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Wellington_Region#/media/File:WellingtonRegionPopulationDensity.png"
                },
                new RegionEntity
                {
                    Id = Guid.Parse("63fb2274-0913-4dfa-ab36-0c4a8be790c8"),
                    Name = "Tasman",
                    Code = "TAS",
                    RegionImageUrl = "https://en.wikipedia.org/wiki/Tasman_District#/media/File:TasmanNelsonRegionPopulationDensity.png"
                }
            };

            modelBuilder.Entity<RegionEntity>().HasData(regions);
        }
    }
}
