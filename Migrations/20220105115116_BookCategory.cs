using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicatie_Web.Migrations
{
    public partial class BookCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Clasa");

            migrationBuilder.DropColumn(
                name: "PublishingDate",
                table: "Clasa");

            migrationBuilder.CreateTable(
                name: "Abonament",
                columns: table => new
                {
                    AbonamentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeAbonament = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PretAbonament = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ValabilitateAbonament = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonament", x => x.AbonamentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abonament");

            migrationBuilder.AddColumn<decimal>(
                name: "Pret",
                table: "Clasa",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishingDate",
                table: "Clasa",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
