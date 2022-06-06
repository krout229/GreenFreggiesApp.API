using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenFreggies.API.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Item",
                table: "Carts",
                newName: "VegetableName");

           
            migrationBuilder.AddColumn<int>(
                name: "VegetablePrice",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropColumn(
                name: "VegetablePrice",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "VegetableName",
                table: "Carts",
                newName: "Item");

            migrationBuilder.AddColumn<decimal>(
                name: "ItemPrice",
                table: "Carts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
