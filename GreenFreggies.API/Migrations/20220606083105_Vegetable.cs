using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenFreggies.API.Migrations
{
    public partial class Vegetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "VegetableDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "VegetableDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "VegetableDetails");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "VegetableDetails");
        }
    }
}
