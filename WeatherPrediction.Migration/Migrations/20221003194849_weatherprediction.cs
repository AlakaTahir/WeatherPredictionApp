using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherPrediction.Migrations.Migrations
{
    public partial class weatherprediction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MinimumTemperature = table.Column<double>(nullable: false),
                    MaximumTemperature = table.Column<double>(nullable: false),
                    RelativeHumidity = table.Column<double>(nullable: false),
                    Wind = table.Column<double>(nullable: false),
                    Visiblity = table.Column<int>(nullable: false),
                    Cloud = table.Column<int>(nullable: false),
                    Dewpoint = table.Column<double>(nullable: false),
                    Pressure = table.Column<double>(nullable: false),
                    DefaultTemperatureSymbol = table.Column<string>(nullable: false),
                    Wetbulb = table.Column<double>(nullable: false),
                    DryBulb = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherInfos");
        }
    }
}
