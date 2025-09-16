using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PF_LAB3_BSIT31A1_JohnAndrei_Guillena.Migrations.GreedDb
{
    /// <inheritdoc />
    public partial class InitialGreedCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    CharacterName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CharacterImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    PowerLevel = table.Column<int>(type: "int", nullable: false),
                    SpecialAbility = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "CharacterImageUrl", "CharacterName", "CreatedByUserId", "DateCreated", "Description", "Name", "PowerLevel", "Rarity", "SpecialAbility" },
                values: new object[,]
                {
                    { 1, 1, 1, null, "Gon Freecss", null, new DateTime(2025, 9, 16, 22, 36, 5, 684, DateTimeKind.Local).AddTicks(9637), "A simple rock throw attack", "Gon's Rock", 3, 1, "Can break through basic defenses" },
                    { 2, 2, 3, null, "Killua Zoldyck", null, new DateTime(2025, 9, 16, 22, 36, 5, 684, DateTimeKind.Local).AddTicks(9642), "Electricity-based attack", "Killua's Lightning", 7, 3, "Paralyzes opponent for one turn" },
                    { 3, 3, 3, null, "Kurapika", null, new DateTime(2025, 9, 16, 22, 36, 5, 684, DateTimeKind.Local).AddTicks(9646), "Judgment chain ability", "Kurapika's Chain", 8, 4, "Can bind and restrict enemy movement" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardType",
                table: "Cards",
                column: "CardType");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Name",
                table: "Cards",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Rarity",
                table: "Cards",
                column: "Rarity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
