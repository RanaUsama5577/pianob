using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class contact_us_update_userId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserObjectId",
                table: "ContactUs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_UserObjectId",
                table: "ContactUs",
                column: "UserObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_AspNetUsers_UserObjectId",
                table: "ContactUs",
                column: "UserObjectId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_AspNetUsers_UserObjectId",
                table: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_ContactUs_UserObjectId",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "UserObjectId",
                table: "ContactUs");
        }
    }
}
