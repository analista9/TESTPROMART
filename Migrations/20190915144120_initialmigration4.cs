using Microsoft.EntityFrameworkCore.Migrations;

namespace HilarioMarket.Migrations
{
    public partial class initialmigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Customer_CustomerIdCustomer",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CustomerIdCustomer",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "CustomerIdCustomer",
                table: "Purchase");

            migrationBuilder.RenameColumn(
                name: "IdCostumer",
                table: "Purchase",
                newName: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_IdCustomer",
                table: "Purchase",
                column: "IdCustomer");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Customer_IdCustomer",
                table: "Purchase",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Customer_IdCustomer",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_IdCustomer",
                table: "Purchase");

            migrationBuilder.RenameColumn(
                name: "IdCustomer",
                table: "Purchase",
                newName: "IdCostumer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerIdCustomer",
                table: "Purchase",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CustomerIdCustomer",
                table: "Purchase",
                column: "CustomerIdCustomer");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Customer_CustomerIdCustomer",
                table: "Purchase",
                column: "CustomerIdCustomer",
                principalTable: "Customer",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
