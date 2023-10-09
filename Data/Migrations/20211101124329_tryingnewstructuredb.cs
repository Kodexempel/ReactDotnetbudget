using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class tryingnewstructuredb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_Budgets_BudgetId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_AspNetUsers_ApplicationUserId",
                table: "Budgets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BudgetCategory",
                table: "BudgetCategory");

            migrationBuilder.RenameTable(
                name: "BudgetCategory",
                newName: "BudgetCategories");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Budgets",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Budgets_ApplicationUserId",
                table: "Budgets",
                newName: "IX_Budgets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BudgetCategory_VariableCostsCategoryId",
                table: "BudgetCategories",
                newName: "IX_BudgetCategories_VariableCostsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BudgetCategory_BudgetId",
                table: "BudgetCategories",
                newName: "IX_BudgetCategories_BudgetId");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "VariableCostsCategories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BudgetCategories",
                table: "BudgetCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_VariableCostsCategories_UserId",
                table: "VariableCostsCategories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategories_Budgets_BudgetId",
                table: "BudgetCategories",
                column: "BudgetId",
                principalTable: "Budgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategories_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategories",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_AspNetUsers_UserId",
                table: "Budgets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_UserId",
                table: "VariableCostsCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategories_Budgets_BudgetId",
                table: "BudgetCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetCategories_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_AspNetUsers_UserId",
                table: "Budgets");

            migrationBuilder.DropForeignKey(
                name: "FK_VariableCostsCategories_AspNetUsers_UserId",
                table: "VariableCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_VariableCostsCategories_UserId",
                table: "VariableCostsCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BudgetCategories",
                table: "BudgetCategories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VariableCostsCategories");

            migrationBuilder.RenameTable(
                name: "BudgetCategories",
                newName: "BudgetCategory");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Budgets",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Budgets_UserId",
                table: "Budgets",
                newName: "IX_Budgets_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BudgetCategories_VariableCostsCategoryId",
                table: "BudgetCategory",
                newName: "IX_BudgetCategory_VariableCostsCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BudgetCategories_BudgetId",
                table: "BudgetCategory",
                newName: "IX_BudgetCategory_BudgetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BudgetCategory",
                table: "BudgetCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_Budgets_BudgetId",
                table: "BudgetCategory",
                column: "BudgetId",
                principalTable: "Budgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetCategory_VariableCostsCategories_VariableCostsCategoryId",
                table: "BudgetCategory",
                column: "VariableCostsCategoryId",
                principalTable: "VariableCostsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_AspNetUsers_ApplicationUserId",
                table: "Budgets",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
