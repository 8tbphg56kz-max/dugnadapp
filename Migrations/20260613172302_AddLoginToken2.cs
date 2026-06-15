using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DugnadApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLoginToken2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Epost",
                table: "Beboere",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "LoginTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BeboerId = table.Column<int>(type: "integer", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    Opprettet = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Utloper = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Brukt = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginTokens_Beboere_BeboerId",
                        column: x => x.BeboerId,
                        principalTable: "Beboere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginTokens_BeboerId",
                table: "LoginTokens",
                column: "BeboerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginTokens");

            migrationBuilder.DropColumn(
                name: "Epost",
                table: "Beboere");
        }
    }
}
