using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DugnadApp.Migrations
{
    /// <inheritdoc />
    public partial class OpprettNyeTabeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Dugnader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Navn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dugnader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deltakelser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BeboerId = table.Column<int>(type: "integer", nullable: false),
                    DugnadId = table.Column<int>(type: "integer", nullable: false),
                    Timer = table.Column<decimal>(type: "numeric", nullable: false),
                    RegistrertDato = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deltakelser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deltakelser_Beboere_BeboerId",
                        column: x => x.BeboerId,
                        principalTable: "Beboere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deltakelser_Dugnader_DugnadId",
                        column: x => x.DugnadId,
                        principalTable: "Dugnader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deltakelser_BeboerId",
                table: "Deltakelser",
                column: "BeboerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deltakelser_DugnadId",
                table: "Deltakelser",
                column: "DugnadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deltakelser");

            migrationBuilder.DropTable(
                name: "Dugnader");

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
    }
}
