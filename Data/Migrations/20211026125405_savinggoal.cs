using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class savinggoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingGoal_AspNetUsers_ApplicationUserId",
                table: "SavingGoal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SavingGoal",
                table: "SavingGoal");

            migrationBuilder.RenameTable(
                name: "SavingGoal",
                newName: "SavingGoals");

            migrationBuilder.RenameIndex(
                name: "IX_SavingGoal_ApplicationUserId",
                table: "SavingGoals",
                newName: "IX_SavingGoals_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavingGoals",
                table: "SavingGoals",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingGoals_AspNetUsers_ApplicationUserId",
                table: "SavingGoals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingGoals_AspNetUsers_ApplicationUserId",
                table: "SavingGoals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SavingGoals",
                table: "SavingGoals");

            migrationBuilder.RenameTable(
                name: "SavingGoals",
                newName: "SavingGoal");

            migrationBuilder.RenameIndex(
                name: "IX_SavingGoals_ApplicationUserId",
                table: "SavingGoal",
                newName: "IX_SavingGoal_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavingGoal",
                table: "SavingGoal",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingGoal_AspNetUsers_ApplicationUserId",
                table: "SavingGoal",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
