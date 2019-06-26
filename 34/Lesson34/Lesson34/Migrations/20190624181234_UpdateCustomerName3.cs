using Microsoft.EntityFrameworkCore.Migrations;

namespace Lesson34.Migrations
{
    public partial class UpdateCustomerName3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customers",
                newSchema: "dbo");

            migrationBuilder.AddUniqueConstraint(
                name: "OQ_Customers_Name",
                schema: "dbo",
                table: "Customers",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "OQ_Customers_Name",
                schema: "dbo",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "dbo",
                newName: "Customers");
        }
    }
}
