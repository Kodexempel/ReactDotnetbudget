using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class removedvehicleandhousing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Housing",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "Vehicle",
                table: "Budgets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Housing",
                table: "Budgets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Vehicle",
                table: "Budgets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
