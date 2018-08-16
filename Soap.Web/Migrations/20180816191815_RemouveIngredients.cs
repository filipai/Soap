using Microsoft.EntityFrameworkCore.Migrations;

namespace Soap.Web.Migrations
{
    public partial class RemouveIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Products",
                nullable: true);
        }
    }
}
