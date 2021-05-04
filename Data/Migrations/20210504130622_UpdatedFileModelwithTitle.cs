using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Data.Migrations
{
    public partial class UpdatedFileModelwithTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ImageFiles",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ImageFiles");
        }
    }
}
