using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_Ex1.DAL.Migrations
{
    public partial class NewColums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Modes",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoldCopies",
                table: "Games",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Modes",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "SoldCopies",
                table: "Games");
        }
    }
}
