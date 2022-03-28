using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class add_address_in_order_details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Latitude",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Longitude",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CartId",
            //    table: "CartIngredients",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AssigneesLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients",
            //    column: "CartId",
            //    principalTable: "Carts",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CartIngredients_Carts_CartId",
            //    table: "CartIngredients");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AssigneesLists");

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
    }
}
