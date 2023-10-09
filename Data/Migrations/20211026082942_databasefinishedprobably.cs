using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class databasefinishedprobably : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_AspNetUsers_UserId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_FixedCostsCategories_FixedCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_FixedCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_UserId",
                table: "BudgetCategory");

            migrationBuilder.DropIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "Sum",
                table: "FixedCostsCategories");

            migrationBuilder.DropColumn(
                name: "FixedCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BudgetCategory");

            migrationBuilder.DropColumn(
                name: "VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.AddColumn<Guid>(
                name: "StandardRefId",
                table: "VariableCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetId",
                table: "FixedCostsCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxSpent",
                table: "BudgetCategory",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "SavingGoal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToSave = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saved = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingGoal_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_StandardRefId",
                table: "VariableCostsCategories",
                column: "StandardRefId",
                unique: true,
                filter: "[StandardRefId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCostsCategories_BudgetId",
                table: "FixedCostsCategories",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingGoal_ApplicationUserId",
                table: "SavingGoal",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_Budgets_BudgetId",
                table: "FixedCostsCategories",
                column: "BudgetId",
                principalTable: "Budgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_StandardRefId",
                table: "VariableCostsCategories",
                column: "StandardRefId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_Budgets_BudgetId",
                table: "FixedCostsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_BudgetCategory_StandardRefId",
                table: "VariableCostsCategories");

            migrationBuilder.DropTable(
                name: "SavingGoal");

            migrationBuilder.DropIndex(
                name: "IX_VariableCostsCategories_StandardRefId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_FixedCostsCategories_BudgetId",
                table: "FixedCostsCategories");

            migrationBuilder.DropColumn(
                name: "StandardRefId",
                table: "VariableCostsCategories");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "FixedCostsCategories");

            migrationBuilder.DropColumn(
                name: "MaxSpent",
                table: "BudgetCategory");

            migrationBuilder.AddColumn<decimal>(
                name: "Sum",
                table: "FixedCostsCategories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "FixedCostsCategoryId",
                table: "BudgetCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BudgetCategory",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VariableCostsCategoryId",
                table: "BudgetCategory",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_FixedCostsCategoryId",
                table: "BudgetCategory",
                column: "FixedCostsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_UserId",
                table: "BudgetCategory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_AspNetUsers_UserId",
                table: "BudgetCategory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_FixedCostsCategories_FixedCostsCategoryId",
                table: "BudgetCategory",
                column: "FixedCostsCategoryId",
                principalTable: "FixedCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
