using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DugnadApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beboere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Seksjonsnr = table.Column<int>(type: "integer", nullable: false),
                    Fornavn = table.Column<string>(type: "text", nullable: false),
                    Etternavn = table.Column<string>(type: "text", nullable: false),
                    Epost = table.Column<string>(type: "text", nullable: false),
                    ErAdmin = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beboere", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dugnader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Navn = table.Column<string>(type: "text", nullable: false),
                    Aktiv = table.Column<bool>(type: "boolean", nullable: false),
                    KreverBeskrivelse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dugnader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leiligheter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Seksjonsnr = table.Column<int>(type: "integer", nullable: false),
                    Leilighetsnr = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leiligheter", x => x.Id);
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
                    Beskrivelse = table.Column<string>(type: "text", nullable: true),
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
                name: "Leiligheter");

            migrationBuilder.DropTable(
                name: "Beboere");

            migrationBuilder.DropTable(
                name: "Dugnader");
        }
    }
}
