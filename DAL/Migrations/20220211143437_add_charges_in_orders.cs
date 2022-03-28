using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class add_charges_in_orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DeliveryCharges",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceCharges",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryCharges",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ServiceCharges",
                table: "Orders");
        }
    }
}
