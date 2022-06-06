using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenFreggies.API.Migrations
{
    public partial class CreatDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orderDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "OrderDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderId");
        }
    }
}
