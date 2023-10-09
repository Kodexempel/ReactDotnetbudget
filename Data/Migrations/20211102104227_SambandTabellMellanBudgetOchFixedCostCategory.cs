using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class SambandTabellMellanBudgetOchFixedCostCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_Budgets_BudgetId",
                table: "FixedCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_FixedCostsCategories_BudgetId",
                table: "FixedCostsCategories");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "FixedCostsCategories");

            migrationBuilder.CreateTable(
                name: "BudgetFixedCostsCategories",
                columns: table => new
                {
                    BudgetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FixedCostsCategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetFixedCostsCategories", x => new { x.BudgetId, x.FixedCostsCategoriesId });
                    table.ForeignKey(
                        name: "FK_BudgetFixedCostsCategories_Budgets_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BudgetFixedCostsCategories_FixedCostsCategories_FixedCostsCategoriesId",
                        column: x => x.FixedCostsCategoriesId,
                        principalTable: "FixedCostsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetFixedCostsCategories_FixedCostsCategoriesId",
                table: "BudgetFixedCostsCategories",
                column: "FixedCostsCategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetFixedCostsCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetId",
                table: "FixedCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FixedCostsCategories_BudgetId",
                table: "FixedCostsCategories",
                column: "BudgetId");

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_Budgets_BudgetId",
                table: "FixedCostsCategories",
                column: "BudgetId",
                principalTable: "Budgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
