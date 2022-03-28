using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class appinfo_social_links : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "AppInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoogleUrl",
                table: "AppInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "AppInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "AppInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeUrl",
                table: "AppInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "AppInfos");

            migrationBuilder.DropColumn(
                name: "GoogleUrl",
                table: "AppInfos");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "AppInfos");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "AppInfos");

            migrationBuilder.DropColumn(
                name: "YoutubeUrl",
                table: "AppInfos");
        }
    }
}
