using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class add_cart_id_nullabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients");

            //migrationBuilder.AlterColumn<int>(
            //    name: "CartId",
            //    table: "CartIngredients",
            //    type: "int",
            //    nullable: true,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients",
            //    column: "CartId",
            //    principalTable: "Carts",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients");

            //migrationBuilder.AlterColumn<int>(
            //    name: "CartId",
            //    table: "CartIngredients",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients",
            //    column: "CartId",
            //    principalTable: "Carts",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
