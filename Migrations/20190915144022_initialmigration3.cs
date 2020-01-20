using Microsoft.EntityFrameworkCore.Migrations;

namespace HilarioMarket.Migrations
{
    public partial class initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Company_IDCompany",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "IDCompany",
                table: "Product",
                newName: "IdCompany");

            migrationBuilder.RenameIndex(
                name: "IX_Product_IDCompany",
                table: "Product",
                newName: "IX_Product_IdCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Company_IdCompany",
                table: "Product",
                column: "IdCompany",
                principalTable: "Company",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Company_IdCompany",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "IdCompany",
                table: "Product",
                newName: "IDCompany");

            migrationBuilder.RenameIndex(
                name: "IX_Product_IdCompany",
                table: "Product",
                newName: "IX_Product_IDCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Company_IDCompany",
                table: "Product",
                column: "IDCompany",
                principalTable: "Company",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
