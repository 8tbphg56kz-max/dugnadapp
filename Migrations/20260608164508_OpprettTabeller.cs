using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DugnadApp.Migrations
{
    /// <inheritdoc />
    public partial class OpprettTabeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Leiligheter",
                table: "Leiligheter");

            migrationBuilder.RenameTable(
                name: "Leiligheter",
                newName: "Leilighet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leilighet",
                table: "Leilighet",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Leilighet",
                table: "Leilighet");

            migrationBuilder.RenameTable(
                name: "Leilighet",
                newName: "Leiligheter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leiligheter",
                table: "Leiligheter",
                column: "Id");
        }
    }
}
