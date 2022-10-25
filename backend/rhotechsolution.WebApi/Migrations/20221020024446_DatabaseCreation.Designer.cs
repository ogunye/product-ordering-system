﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rhotechsolution.PersistenceData.ApplicationDbContext;

#nullable disable

namespace rhotechsolution.WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20221020024446_DatabaseCreation")]
    partial class DatabaseCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Area_locality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("House_number")
                        .HasColumnType("int");

                    b.Property<string>("Province_State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Zip_postalcode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Customer_ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsCustomerActive")
                        .HasColumnType("bit");

                    b.Property<string>("Middle_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Organisation_name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone_Number")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SalePerson_ID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("SaleOrder_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("LineTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderQty")
                        .HasColumnType("int");

                    b.Property<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<int>("SalesOrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("Unit_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Payment_Method", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Customer_Account")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Invoice_ID")
                        .HasColumnType("int");

                    b.Property<string>("Transaction_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payment_Methods");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscontinueDate")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("IsProductAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("ProductQty")
                        .HasColumnType("int");

                    b.Property<int>("product_category_id")
                        .HasColumnType("int");

                    b.Property<string>("product_description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Product_Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date_From")
                        .HasColumnType("datetime2");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Product_Retail_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Product_Wholesales_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Product_ID")
                        .IsUnique();

                    b.ToTable("Product_Prices");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Product_Shipment", b =>
                {
                    b.Property<int>("Shippment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shippment_ID"), 1L, 1);

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDelivered")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateShipped")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inovice_ID")
                        .HasColumnType("int");

                    b.Property<int>("SaleOrder_ID")
                        .HasColumnType("int");

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Shippment_ID");

                    b.HasIndex("Inovice_ID");

                    b.ToTable("Product_Shipments");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category_Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod_ID")
                        .HasColumnType("int");

                    b.Property<string>("SalesOrderStatus")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Sub_Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total_Due")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethod_ID");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.SalesPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumberofClient")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SalesPeople");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Address", b =>
                {
                    b.HasOne("rhotechsolution.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Product_Price", b =>
                {
                    b.HasOne("rhotechsolution.Domain.Entities.Product", "Product")
                        .WithOne("Product_Price")
                        .HasForeignKey("rhotechsolution.Domain.Entities.Product_Price", "Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Product_Shipment", b =>
                {
                    b.HasOne("rhotechsolution.Domain.Entities.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("Inovice_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.SalesOrder", b =>
                {
                    b.HasOne("rhotechsolution.Domain.Entities.Payment_Method", "Payment_Method")
                        .WithMany()
                        .HasForeignKey("PaymentMethod_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment_Method");
                });

            modelBuilder.Entity("rhotechsolution.Domain.Entities.Product", b =>
                {
                    b.Navigation("Product_Price");
                });
#pragma warning restore 612, 618
        }
    }
}