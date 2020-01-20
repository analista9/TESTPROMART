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
    [Migration("20190915142855_initialmigration")]
    partial class initialmigration
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

                    b.ToTable("Company");
                });

            modelBuilder.Entity("HilarioMarket.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BaseAmount");

                    b.Property<string>("Description");

                    b.Property<int>("IDCompany");

                    b.Property<double>("MarketAmount");

                    b.Property<int>("Quantity");

                    b.HasKey("IdProduct");

                    b.HasIndex("IDCompany");

                    b.ToTable("Product");
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

                    b.ToTable("PurchaseDetails");
                });

            modelBuilder.Entity("HilarioMarket.Models.Product", b =>
                {
                    b.HasOne("HilarioMarket.Models.Company")
                        .WithMany("products")
                        .HasForeignKey("IDCompany")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HilarioMarket.Models.PurchaseDetails", b =>
                {
                    b.HasOne("HilarioMarket.Models.Product")
                        .WithMany("purchaseDetails")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}