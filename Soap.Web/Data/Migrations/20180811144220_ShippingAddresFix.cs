using Microsoft.EntityFrameworkCore.Migrations;

namespace Soap.Web.Data.Migrations
{
    public partial class ShippingAddresFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SippingAddressId",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SippingAddressId",
                table: "Order",
                nullable: true);
        }
    }
}
