using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class purchasenowhavevariablecategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "VariableCostsCategoriesId",
                table: "Purchases",
                newName: "VariableCostsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_VariableCostsCategoriesId",
                table: "Purchases",
                newName: "IX_Purchases_VariableCostsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoryId",
                table: "Purchases",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoryId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "VariableCostsCategoryId",
                table: "Purchases",
                newName: "VariableCostsCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_VariableCostsCategoryId",
                table: "Purchases",
                newName: "IX_Purchases_VariableCostsCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_VariableCostsCategories_VariableCostsCategoriesId",
                table: "Purchases",
                column: "VariableCostsCategoriesId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
