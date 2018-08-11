using Microsoft.EntityFrameworkCore.Migrations;

namespace Soap.Web.Data.Migrations
{
    public partial class AddingFieldsInProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPageId",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductPageId",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }
    }
}
