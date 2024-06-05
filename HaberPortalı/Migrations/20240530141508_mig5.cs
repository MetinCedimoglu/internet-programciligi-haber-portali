using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaberPortalı.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newss_AspNetUsers_AppUserId",
                table: "Newss");

            migrationBuilder.DropIndex(
                name: "IX_Newss_AppUserId",
                table: "Newss");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Newss");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Newss");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Newss",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Newss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Newss_AppUserId",
                table: "Newss",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Newss_AspNetUsers_AppUserId",
                table: "Newss",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
