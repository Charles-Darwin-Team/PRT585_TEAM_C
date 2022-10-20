using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2DataAccessLayer.Migrations
{
    public partial class Moviesecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieName",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "MovieName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieId");
        }
    }
}
