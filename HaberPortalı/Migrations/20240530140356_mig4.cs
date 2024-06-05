using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaberPortalı.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newss_Authors_AuthorId",
                table: "Newss");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Newss");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Newss",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Newss_Authors_AuthorId",
                table: "Newss",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newss_Authors_AuthorId",
                table: "Newss");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Newss",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Newss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Newss_Authors_AuthorId",
                table: "Newss",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
