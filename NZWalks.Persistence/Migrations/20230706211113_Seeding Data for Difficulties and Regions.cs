using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("428135c4-815c-4957-9042-a519b8adc4b3"), "Hard" },
                    { new Guid("4e924955-31ad-4e52-a6ec-e92197f8801a"), "Medium" },
                    { new Guid("6d80d353-e9df-44c9-bbc8-3c23875d65db"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0313863e-057a-494e-87a2-a1d6770041da"), "WGN", "Wellington", "https://en.wikipedia.org/wiki/Wellington_Region#/media/File:WellingtonRegionPopulationDensity.png" },
                    { new Guid("2c42dc59-83e6-4316-acb5-11399adbb71b"), "GIS", "Gisborne", "https://en.wikipedia.org/wiki/Gisborne_District#/media/File:GisborneRegionPopulationDensity.png" },
                    { new Guid("3f9f6091-54f3-4771-9249-6e30738d3181"), "BOP", "Bay of Plenty", "https://en.wikipedia.org/wiki/Bay_of_Plenty_Region#/media/File:BayOfPlentyRegionPopulationDensity.png" },
                    { new Guid("63fb2274-0913-4dfa-ab36-0c4a8be790c8"), "TAS", "Tasman", "https://en.wikipedia.org/wiki/Tasman_District#/media/File:TasmanNelsonRegionPopulationDensity.png" },
                    { new Guid("661098d8-3e56-4e7b-a5fa-e279d7bcc72d"), "NTL", "Northland", "https://upload.wikimedia.org/wikipedia/commons/9/9d/NorthlandRegionPopulationDensity.png" },
                    { new Guid("a82f00c8-e4be-4225-b005-9591438bd854"), "MWT", "Manawatū-Whanganui", "https://en.wikipedia.org/wiki/Manawat%C5%AB-Whanganui#/media/File:ManawatuWanganuiRegionPopulationDensity.png" },
                    { new Guid("ad726936-6b1b-45f0-b799-0dfd94736d6c"), "TKI", "Taranaki", "https://en.wikipedia.org/wiki/Taranaki#/media/File:TaranakiRegionPopulationDensity.png" },
                    { new Guid("c941fc11-ca82-4487-91d5-0c6707a31034"), "WKO", "Waikato", "https://en.wikipedia.org/wiki/Waikato#/media/File:NZTerritorialAuthorities-Waikato.png" },
                    { new Guid("dd2a524c-14a6-4804-bd1c-05e8529bae7c"), "HKB", "Hawke's Bay", "https://en.wikipedia.org/wiki/Hawke%27s_Bay#/media/File:HawkesBayRegionPopulationDensity.png" },
                    { new Guid("dd68cf7c-4811-44b5-b753-2a6dbc0ad22d"), "AUK", "Auckland", "https://en.wikipedia.org/wiki/Auckland_Region#/media/File:Auckland.arp.750pix.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("428135c4-815c-4957-9042-a519b8adc4b3"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("4e924955-31ad-4e52-a6ec-e92197f8801a"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("6d80d353-e9df-44c9-bbc8-3c23875d65db"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0313863e-057a-494e-87a2-a1d6770041da"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2c42dc59-83e6-4316-acb5-11399adbb71b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3f9f6091-54f3-4771-9249-6e30738d3181"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("63fb2274-0913-4dfa-ab36-0c4a8be790c8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("661098d8-3e56-4e7b-a5fa-e279d7bcc72d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a82f00c8-e4be-4225-b005-9591438bd854"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ad726936-6b1b-45f0-b799-0dfd94736d6c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c941fc11-ca82-4487-91d5-0c6707a31034"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd2a524c-14a6-4804-bd1c-05e8529bae7c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd68cf7c-4811-44b5-b753-2a6dbc0ad22d"));
        }
    }
}
