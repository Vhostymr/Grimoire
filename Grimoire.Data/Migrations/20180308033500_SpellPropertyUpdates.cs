using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Grimoire.Data.Migrations
{
    public partial class SpellPropertyUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Range",
                table: "Spells",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Spells",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "CastingTime",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSomatic",
                table: "Spells",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerbal",
                table: "Spells",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Spells",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CastingTime",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "IsSomatic",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "IsVerbal",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Spells");

            migrationBuilder.AlterColumn<int>(
                name: "Range",
                table: "Spells",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Spells",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
