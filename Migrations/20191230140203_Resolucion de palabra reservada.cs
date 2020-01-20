using Microsoft.EntityFrameworkCore.Migrations;

namespace HilarioMarket.Migrations
{
    public partial class Resoluciondepalabrareservada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Company_IdCompany",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Customer_IdCustomer",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetail_Product_IdProduct",
                table: "PurchaseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetail_Purchase_IdPurchase",
                table: "PurchaseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseDetail",
                table: "PurchaseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "HilarioMarket_User");

            migrationBuilder.RenameTable(
                name: "PurchaseDetail",
                newName: "HilarioMarket_PurchaseDetail");

            migrationBuilder.RenameTable(
                name: "Purchase",
                newName: "HilarioMarket_Purchase");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "HilarioMarket_Product");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "HilarioMarket_Customer");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "HilarioMarket_Company");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseDetail_IdPurchase",
                table: "HilarioMarket_PurchaseDetail",
                newName: "IX_HilarioMarket_PurchaseDetail_IdPurchase");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseDetail_IdProduct",
                table: "HilarioMarket_PurchaseDetail",
                newName: "IX_HilarioMarket_PurchaseDetail_IdProduct");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_IdCustomer",
                table: "HilarioMarket_Purchase",
                newName: "IX_HilarioMarket_Purchase_IdCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_Product_IdCompany",
                table: "HilarioMarket_Product",
                newName: "IX_HilarioMarket_Product_IdCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HilarioMarket_User",
                table: "HilarioMarket_User",
                column: "IdUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HilarioMarket_PurchaseDetail",
                table: "HilarioMarket_PurchaseDetail",
                column: "IdPurchaseDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HilarioMarket_Purchase",
                table: "HilarioMarket_Purchase",
                column: "IdPurchase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HilarioMarket_Product",
                table: "HilarioMarket_Product",
                column: "IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HilarioMarket_Customer",
                table: "HilarioMarket_Customer",
                column: "IdCustomer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HilarioMarket_Company",
                table: "HilarioMarket_Company",
                column: "IdCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_HilarioMarket_Product_HilarioMarket_Company_IdCompany",
                table: "HilarioMarket_Product",
                column: "IdCompany",
                principalTable: "HilarioMarket_Company",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HilarioMarket_Purchase_HilarioMarket_Customer_IdCustomer",
                table: "HilarioMarket_Purchase",
                column: "IdCustomer",
                principalTable: "HilarioMarket_Customer",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HilarioMarket_PurchaseDetail_HilarioMarket_Product_IdProduct",
                table: "HilarioMarket_PurchaseDetail",
                column: "IdProduct",
                principalTable: "HilarioMarket_Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HilarioMarket_PurchaseDetail_HilarioMarket_Purchase_IdPurchase",
                table: "HilarioMarket_PurchaseDetail",
                column: "IdPurchase",
                principalTable: "HilarioMarket_Purchase",
                principalColumn: "IdPurchase",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HilarioMarket_Product_HilarioMarket_Company_IdCompany",
                table: "HilarioMarket_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_HilarioMarket_Purchase_HilarioMarket_Customer_IdCustomer",
                table: "HilarioMarket_Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_HilarioMarket_PurchaseDetail_HilarioMarket_Product_IdProduct",
                table: "HilarioMarket_PurchaseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_HilarioMarket_PurchaseDetail_HilarioMarket_Purchase_IdPurchase",
                table: "HilarioMarket_PurchaseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HilarioMarket_User",
                table: "HilarioMarket_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HilarioMarket_PurchaseDetail",
                table: "HilarioMarket_PurchaseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HilarioMarket_Purchase",
                table: "HilarioMarket_Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HilarioMarket_Product",
                table: "HilarioMarket_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HilarioMarket_Customer",
                table: "HilarioMarket_Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HilarioMarket_Company",
                table: "HilarioMarket_Company");

            migrationBuilder.RenameTable(
                name: "HilarioMarket_User",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "HilarioMarket_PurchaseDetail",
                newName: "PurchaseDetail");

            migrationBuilder.RenameTable(
                name: "HilarioMarket_Purchase",
                newName: "Purchase");

            migrationBuilder.RenameTable(
                name: "HilarioMarket_Product",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "HilarioMarket_Customer",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "HilarioMarket_Company",
                newName: "Company");

            migrationBuilder.RenameIndex(
                name: "IX_HilarioMarket_PurchaseDetail_IdPurchase",
                table: "PurchaseDetail",
                newName: "IX_PurchaseDetail_IdPurchase");

            migrationBuilder.RenameIndex(
                name: "IX_HilarioMarket_PurchaseDetail_IdProduct",
                table: "PurchaseDetail",
                newName: "IX_PurchaseDetail_IdProduct");

            migrationBuilder.RenameIndex(
                name: "IX_HilarioMarket_Purchase_IdCustomer",
                table: "Purchase",
                newName: "IX_Purchase_IdCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_HilarioMarket_Product_IdCompany",
                table: "Product",
                newName: "IX_Product_IdCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "IdUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseDetail",
                table: "PurchaseDetail",
                column: "IdPurchaseDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "IdPurchase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "IdCustomer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "IdCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Company_IdCompany",
                table: "Product",
                column: "IdCompany",
                principalTable: "Company",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Customer_IdCustomer",
                table: "Purchase",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetail_Product_IdProduct",
                table: "PurchaseDetail",
                column: "IdProduct",
                principalTable: "Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetail_Purchase_IdPurchase",
                table: "PurchaseDetail",
                column: "IdPurchase",
                principalTable: "Purchase",
                principalColumn: "IdPurchase",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
