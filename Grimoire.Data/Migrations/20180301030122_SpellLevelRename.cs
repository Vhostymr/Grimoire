using Microsoft.EntityFrameworkCore.Migrations;

namespace Grimoire.Data.Migrations
{
    public partial class SpellLevelRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Spells",
                newName: "SpellLevel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpellLevel",
                table: "Spells",
                newName: "Level");
        }
    }
}
