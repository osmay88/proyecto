using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Data.Migrations
{
    public partial class UpdatedFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ImageFiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "ImageFiles",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ImageFiles");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "ImageFiles");
        }
    }
}
