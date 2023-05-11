using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace forsyning_gev.Migrations
{
    /// <inheritdoc />
    public partial class Ind3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Spoof",
                table: "Spoof");

            migrationBuilder.RenameTable(
                name: "Spoof",
                newName: "Spoofer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spoofer",
                table: "Spoofer",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Spoofer",
                table: "Spoofer");

            migrationBuilder.RenameTable(
                name: "Spoofer",
                newName: "Spoof");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spoof",
                table: "Spoof",
                column: "Id");
        }
    }
}
