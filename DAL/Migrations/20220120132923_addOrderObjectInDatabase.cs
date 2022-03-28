using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addOrderObjectInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CartIngredients");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OrderId",
                table: "Carts",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Orders_OrderId",
                table: "Carts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Orders_OrderId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_OrderId",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CartIngredients",
                type: "int",
                nullable: true);
        }
    }
}
