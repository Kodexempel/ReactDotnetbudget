using Microsoft.EntityFrameworkCore.Migrations;

namespace JohannasReactProject.Data.Migrations
{
    public partial class addedUserToFixedCostCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FixedCostsCategories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FixedCostsCategories_UserId",
                table: "FixedCostsCategories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_UserId",
                table: "FixedCostsCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCostsCategories_AspNetUsers_UserId",
                table: "FixedCostsCategories");

            migrationBuilder.DropIndex(
                name: "IX_FixedCostsCategories_UserId",
                table: "FixedCostsCategories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FixedCostsCategories");
        }
    }
}
