using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DugnadApp.Migrations
{
    /// <inheritdoc />
    public partial class OpprettBoolIDugnad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktiv",
                table: "Dugnader",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktiv",
                table: "Dugnader");
        }
    }
}
