using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class update_app_info_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DeliveryCharges",
                table: "AppInfos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceCharges",
                table: "AppInfos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryCharges",
                table: "AppInfos");

            migrationBuilder.DropColumn(
                name: "ServiceCharges",
                table: "AppInfos");
        }
    }
}
