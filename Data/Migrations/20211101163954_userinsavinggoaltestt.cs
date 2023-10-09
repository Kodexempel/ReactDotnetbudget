using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class userinsavinggoaltestt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingGoals_AspNetUsers_ApplicationUserId",
                table: "SavingGoals");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "SavingGoals",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SavingGoals_ApplicationUserId",
                table: "SavingGoals",
                newName: "IX_SavingGoals_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingGoals_AspNetUsers_UserId",
                table: "SavingGoals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingGoals_AspNetUsers_UserId",
                table: "SavingGoals");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SavingGoals",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SavingGoals_UserId",
                table: "SavingGoals",
                newName: "IX_SavingGoals_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingGoals_AspNetUsers_ApplicationUserId",
                table: "SavingGoals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
