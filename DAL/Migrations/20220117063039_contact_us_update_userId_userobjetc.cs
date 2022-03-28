using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class contact_us_update_userId_userobjetc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_AspNetUsers_UserObjectId",
                table: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_ContactUs_UserObjectId",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "UserObjectId",
                table: "ContactUs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ContactUs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_UserId",
                table: "ContactUs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_AspNetUsers_UserId",
                table: "ContactUs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_AspNetUsers_UserId",
                table: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_ContactUs_UserId",
                table: "ContactUs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
    }
}
