using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedRepository.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FatDetails_ProductId",
                table: "FatDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_FatDetails_Products_ProductId",
                table: "FatDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FatDetails_Products_ProductId",
                table: "FatDetails");

            migrationBuilder.DropIndex(
                name: "IX_FatDetails_ProductId",
                table: "FatDetails");
        }
    }
}
