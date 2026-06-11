using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DugnadApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBeskrivelseToDeltakelse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Beskrivelse",
                table: "Deltakelser",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beskrivelse",
                table: "Deltakelser");
        }
    }
}
