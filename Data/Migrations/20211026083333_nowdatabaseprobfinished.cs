using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class nowdatabaseprobfinished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_StandardRefId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_VariableCostsCategories_StandardRefId",
                table: "VariableCostsCategories");

            migrationBuilder.DropColumn(
                name: "StandardRefId",
                table: "VariableCostsCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "VariableCostsCategoryId",
                table: "BudgetCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.AddColumn<Guid>(
                name: "StandardRefId",
                table: "VariableCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_StandardRefId",
                table: "VariableCostsCategories",
                column: "StandardRefId",
                unique: true,
                filter: "[StandardRefId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_StandardRefId",
                table: "VariableCostsCategories",
                column: "StandardRefId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
