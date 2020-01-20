﻿// <auto-generated />
using HilarioMarket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HilarioMarket.Migrations
{
    [DbContext(typeof(HilarioMarketServiceContext))]
    [Migration("20191230140203_Resolucion de palabra reservada")]
    partial class Resoluciondepalabrareservada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HilarioMarket.Models.Company", b =>
                {
                    b.Property<int>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("IdCompany");

                    b.ToTable("HilarioMarket_Company");
                });

            modelBuilder.Entity("HilarioMarket.Models.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("FrequentBuyer");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("IdCustomer");

                    b.ToTable("HilarioMarket_Customer");
                });

            modelBuilder.Entity("HilarioMarket.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BaseAmount");

                    b.Property<string>("Description");

                    b.Property<int>("IdCompany");

                    b.Property<double>("MarketAmount");

                    b.Property<int>("Quantity");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdCompany");

                    b.ToTable("HilarioMarket_Product");
                });

            modelBuilder.Entity("HilarioMarket.Models.Purchase", b =>
                {
                    b.Property<int>("IdPurchase")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("IdCustomer");

                    b.HasKey("IdPurchase");

                    b.HasIndex("IdCustomer");

                    b.ToTable("HilarioMarket_Purchase");
                });

            modelBuilder.Entity("HilarioMarket.Models.PurchaseDetails", b =>
                {
                    b.Property<int>("IdPurchaseDetails")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduct");

                    b.Property<int>("IdPurchase");

                    b.Property<int>("Quantity");

                    b.Property<double>("TotalAmount");

                    b.Property<double>("UnitPrice");

                    b.HasKey("IdPurchaseDetails");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdPurchase");

                    b.ToTable("HilarioMarket_PurchaseDetail");
                });

            modelBuilder.Entity("HilarioMarket.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("IdUser");

                    b.ToTable("HilarioMarket_User");
                });

            modelBuilder.Entity("HilarioMarket.Models.Product", b =>
                {
                    b.HasOne("HilarioMarket.Models.Company")
                        .WithMany("products")
                        .HasForeignKey("IdCompany")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HilarioMarket.Models.Purchase", b =>
                {
                    b.HasOne("HilarioMarket.Models.Customer")
                        .WithMany("purchases")
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HilarioMarket.Models.PurchaseDetails", b =>
                {
                    b.HasOne("HilarioMarket.Models.Product")
                        .WithMany("purchaseDetails")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HilarioMarket.Models.Purchase")
                        .WithMany("purchaseDetails")
                        .HasForeignKey("IdPurchase")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
