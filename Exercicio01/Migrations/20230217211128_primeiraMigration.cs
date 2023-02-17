using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Exercicio01.Migrations
{
    /// <inheritdoc />
    public partial class primeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Created_at", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1710), "Abner Da Silva De Moraes " },
                    { 2, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1724), "Adriana De Jesus Amorim" },
                    { 3, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1730), "Heitor Peres Trevisan Filho" },
                    { 4, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1731), "Klaus Kartanas Palhas" },
                    { 5, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1733), "Mary Hellen Oliveira Botelho" },
                    { 6, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1735), "Roberto Sidney Fahl De Oliveira" },
                    { 7, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1737), "Vanessa Cristina Lourenço Yasuhara" },
                    { 8, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1738), "Yngrid De Brito Oliveira" },
                    { 9, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1740), "Sérgio Rômulo Alves Dos Santos Júnior" },
                    { 10, new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1741), "Wagner Moises Costa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
