using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class qaunaityt_in_cart_ingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartIngredients");
        }
    }
}
