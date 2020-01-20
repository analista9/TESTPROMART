using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HilarioMarket.Migrations
{
    public partial class initialmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_Product_IdProduct",
                table: "PurchaseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseDetails",
                table: "PurchaseDetails");

            migrationBuilder.RenameTable(
                name: "PurchaseDetails",
                newName: "PurchaseDetail");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseDetails_IdProduct",
                table: "PurchaseDetail",
                newName: "IX_PurchaseDetail_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseDetail",
                table: "PurchaseDetail",
                column: "IdPurchaseDetails");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FrequentBuyer = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    IdPurchase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: false),
                    IdCostumer = table.Column<int>(nullable: false),
                    CustomerIdCustomer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.IdPurchase);
                    table.ForeignKey(
                        name: "FK_Purchase_Customer_CustomerIdCustomer",
                        column: x => x.CustomerIdCustomer,
                        principalTable: "Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetail_IdPurchase",
                table: "PurchaseDetail",
                column: "IdPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CustomerIdCustomer",
                table: "Purchase",
                column: "CustomerIdCustomer");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetail_Product_IdProduct",
                table: "PurchaseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetail_Purchase_IdPurchase",
                table: "PurchaseDetail");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseDetail",
                table: "PurchaseDetail");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseDetail_IdPurchase",
                table: "PurchaseDetail");

            migrationBuilder.RenameTable(
                name: "PurchaseDetail",
                newName: "PurchaseDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseDetail_IdProduct",
                table: "PurchaseDetails",
                newName: "IX_PurchaseDetails_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseDetails",
                table: "PurchaseDetails",
                column: "IdPurchaseDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Product_IdProduct",
                table: "PurchaseDetails",
                column: "IdProduct",
                principalTable: "Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
