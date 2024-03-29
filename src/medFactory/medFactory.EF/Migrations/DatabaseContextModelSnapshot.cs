﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using medFactory.EF;

#nullable disable

namespace medFactory.EF.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.HasSequence("Customer_seq");

            modelBuilder.HasSequence("Manufacturer_seq");

            modelBuilder.HasSequence("PrescriptionDrugs_seq");

            modelBuilder.HasSequence("Supplier_seq");

            modelBuilder.HasSequence("Users_seq");

            modelBuilder.Entity("medFactory.Domain.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("address");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("AllocatedDoctor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("allocated_doctor");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("customer_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("gender");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint")
                        .HasColumnName("mobile");

                    b.Property<int>("Pincode")
                        .HasColumnType("int")
                        .HasColumnName("pincode");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Drug", b =>
                {
                    b.Property<int>("DrugId")
                        .HasColumnType("int")
                        .HasColumnName("drugID");

                    b.Property<string>("DrugName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("drug_name");

                    b.Property<string>("DrugClass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("drug_class");

                    b.Property<string>("DrugGenericName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(false)
                        .HasColumnType("varchar(75)")
                        .HasColumnName("drug_generic_name");

                    b.Property<string>("DrugProductType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("drug_product_type");

                    b.Property<string>("DrugTargetSystem")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("drug_target_system");

                    b.Property<string>("DrugType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("drug_type");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int")
                        .HasColumnName("manufacturerID");

                    b.Property<int>("MaxRetailPrice")
                        .HasColumnType("int")
                        .HasColumnName("max_retail_price");

                    b.Property<int>("PurchasePrice")
                        .HasColumnType("int")
                        .HasColumnName("purchase_price");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplierID");

                    b.HasKey("DrugId", "DrugName")
                        .HasName("Drugs_pk");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int")
                        .HasColumnName("manufacturerID");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("address");

                    b.Property<string>("ManufacturerLicense")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("manufacturer_license");

                    b.Property<string>("ManufacturerName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("manufacturer_name");

                    b.Property<int>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturer", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.OnPurchaseInvoice", b =>
                {
                    b.Property<int>("PurchaseInvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("purchaseInvoiceID");

                    b.Property<int>("BatchNo")
                        .HasColumnType("int")
                        .HasColumnName("batch_no");

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("date")
                        .HasColumnName("date_of_entry");

                    b.Property<int>("DrugName")
                        .HasColumnType("int")
                        .HasColumnName("drug_name");

                    b.Property<int>("DrugPurchaseTotal")
                        .HasColumnType("int")
                        .HasColumnName("drug_purchase_total");

                    b.Property<int>("DrugQuantity")
                        .HasColumnType("int")
                        .HasColumnName("drug_quantity");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("date")
                        .HasColumnName("expiry_date");

                    b.Property<DateTime>("ManufactureAte")
                        .HasColumnType("date")
                        .HasColumnName("manufacture_ate");

                    b.HasKey("PurchaseInvoiceId")
                        .HasName("OnPurchaseInvoice_pk");

                    b.HasIndex(new[] { "BatchNo" }, "OnPurchaseInvoice_ak")
                        .IsUnique();

                    b.ToTable("OnPurchaseInvoice", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.OnSalesInvoice", b =>
                {
                    b.Property<int>("OnSalesInvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("on_sales_invoiceID");

                    b.Property<int>("DrugName")
                        .HasColumnType("int")
                        .HasColumnName("drug_name");

                    b.Property<int>("DrugPriceTotal")
                        .HasColumnType("int")
                        .HasColumnName("drug_price_total");

                    b.Property<int>("DrugQuantity")
                        .HasColumnType("int")
                        .HasColumnName("drug_quantity");

                    b.HasKey("OnSalesInvoiceId");

                    b.ToTable("OnSalesInvoice", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("orderID");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<int>("PayDate")
                        .HasColumnType("int")
                        .HasColumnName("pay_date");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int")
                        .HasColumnName("prescriptionID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userID");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.OrderedDrug", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("orderID");

                    b.Property<int>("BatchNo")
                        .HasColumnType("int")
                        .HasColumnName("batch_no");

                    b.Property<int>("DrugId")
                        .HasColumnType("int")
                        .HasColumnName("drugID");

                    b.Property<int>("DrugName")
                        .HasColumnType("int")
                        .HasColumnName("drug_name");

                    b.Property<int>("OrderedQuantity")
                        .HasColumnType("int")
                        .HasColumnName("ordered_quantity");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.HasKey("OrderId")
                        .HasName("OrderedDrugs_pk");

                    b.HasIndex("DrugId");

                    b.ToTable("OrderedDrugs");
                });

            modelBuilder.Entity("medFactory.Domain.Models.PurchaseInvoice", b =>
                {
                    b.Property<int>("PurchaseInvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("purchase_invoiceID");

                    b.Property<int>("PayedAmount")
                        .HasColumnType("int")
                        .HasColumnName("payed_amount");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int")
                        .HasColumnName("payment_type");

                    b.Property<int>("RemainingAmount")
                        .HasColumnType("int")
                        .HasColumnName("remaining_amount");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplierID");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int")
                        .HasColumnName("total_amount");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userID");

                    b.HasKey("PurchaseInvoiceId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UserId");

                    b.ToTable("PurchaseInvoice", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.SaleInvoice", b =>
                {
                    b.Property<int>("SaleInvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("sale_invoiceID");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<int>("Discount")
                        .HasColumnType("int")
                        .HasColumnName("discount");

                    b.Property<int>("NewAmount")
                        .HasColumnType("int")
                        .HasColumnName("new_amount");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("date")
                        .HasColumnName("pay_date");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("payment_type");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int")
                        .HasColumnName("total_amount");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userID");

                    b.HasKey("SaleInvoiceId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("SaleInvoice", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.Stock", b =>
                {
                    b.Property<int>("DrugId")
                        .HasColumnType("int")
                        .HasColumnName("drugID");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("date")
                        .HasColumnName("expiry_date");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("manufacturer_name");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int")
                        .HasColumnName("stock_quantity");

                    b.HasKey("DrugId")
                        .HasName("Stock_pk");

                    b.ToTable("Stock", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplierID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("address");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint")
                        .HasColumnName("phone");

                    b.Property<string>("SupplierName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("supplier_name");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("medFactory.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userID");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Drug", b =>
                {
                    b.HasOne("medFactory.Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany("Drugs")
                        .HasForeignKey("ManufacturerId")
                        .IsRequired()
                        .HasConstraintName("manufactures");

                    b.HasOne("medFactory.Domain.Models.Supplier", "Supplier")
                        .WithMany("Drugs")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("supplies");

                    b.Navigation("Manufacturer");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("medFactory.Domain.Models.OnPurchaseInvoice", b =>
                {
                    b.HasOne("medFactory.Domain.Models.PurchaseInvoice", "PurchaseInvoice")
                        .WithOne("OnPurchaseInvoice")
                        .HasForeignKey("medFactory.Domain.Models.OnPurchaseInvoice", "PurchaseInvoiceId")
                        .IsRequired()
                        .HasConstraintName("consists_of_purchased_drugs");

                    b.Navigation("PurchaseInvoice");
                });

            modelBuilder.Entity("medFactory.Domain.Models.OnSalesInvoice", b =>
                {
                    b.HasOne("medFactory.Domain.Models.SaleInvoice", "OnSalesInvoiceNavigation")
                        .WithOne("OnSalesInvoice")
                        .HasForeignKey("medFactory.Domain.Models.OnSalesInvoice", "OnSalesInvoiceId")
                        .IsRequired()
                        .HasConstraintName("consists_of_saled_drugs");

                    b.Navigation("OnSalesInvoiceNavigation");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Order", b =>
                {
                    b.HasOne("medFactory.Domain.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("gives");

                    b.HasOne("medFactory.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("Order_Users");

                    b.Navigation("Customer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("medFactory.Domain.Models.OrderedDrug", b =>
                {
                    b.HasOne("medFactory.Domain.Models.Stock", "Drug")
                        .WithMany("OrderedDrugs")
                        .HasForeignKey("DrugId")
                        .IsRequired()
                        .HasConstraintName("fulfilled_from");

                    b.HasOne("medFactory.Domain.Models.Order", "Order")
                        .WithOne("OrderedDrug")
                        .HasForeignKey("medFactory.Domain.Models.OrderedDrug", "OrderId")
                        .IsRequired()
                        .HasConstraintName("consists_of_ordered_drugs");

                    b.Navigation("Drug");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("medFactory.Domain.Models.PurchaseInvoice", b =>
                {
                    b.HasOne("medFactory.Domain.Models.Supplier", "Supplier")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("gets_paid_for");

                    b.HasOne("medFactory.Domain.Models.User", "User")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("PurchaseInvoice_Users");

                    b.Navigation("Supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("medFactory.Domain.Models.SaleInvoice", b =>
                {
                    b.HasOne("medFactory.Domain.Models.Customer", "Customer")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("pays");

                    b.HasOne("medFactory.Domain.Models.Order", "SaleInvoiceNavigation")
                        .WithOne("SaleInvoice")
                        .HasForeignKey("medFactory.Domain.Models.SaleInvoice", "SaleInvoiceId")
                        .IsRequired()
                        .HasConstraintName("order_generates_sale_invoice");

                    b.HasOne("medFactory.Domain.Models.User", "User")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("SaleInvoice_Users");

                    b.Navigation("Customer");

                    b.Navigation("SaleInvoiceNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("SaleInvoices");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Manufacturer", b =>
                {
                    b.Navigation("Drugs");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Order", b =>
                {
                    b.Navigation("OrderedDrug")
                        .IsRequired();

                    b.Navigation("SaleInvoice")
                        .IsRequired();
                });

            modelBuilder.Entity("medFactory.Domain.Models.PurchaseInvoice", b =>
                {
                    b.Navigation("OnPurchaseInvoice")
                        .IsRequired();
                });

            modelBuilder.Entity("medFactory.Domain.Models.SaleInvoice", b =>
                {
                    b.Navigation("OnSalesInvoice")
                        .IsRequired();
                });

            modelBuilder.Entity("medFactory.Domain.Models.Stock", b =>
                {
                    b.Navigation("OrderedDrugs");
                });

            modelBuilder.Entity("medFactory.Domain.Models.Supplier", b =>
                {
                    b.Navigation("Drugs");

                    b.Navigation("PurchaseInvoices");
                });

            modelBuilder.Entity("medFactory.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PurchaseInvoices");

                    b.Navigation("SaleInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
