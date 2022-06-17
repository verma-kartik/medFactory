using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace medFactory.EF.Migrations
{
    public partial class generateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "Customer_seq");

            migrationBuilder.CreateSequence(
                name: "Manufacturer_seq");

            migrationBuilder.CreateSequence(
                name: "PrescriptionDrugs_seq");

            migrationBuilder.CreateSequence(
                name: "Supplier_seq");

            migrationBuilder.CreateSequence(
                name: "Users_seq");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerID = table.Column<int>(type: "int", nullable: false),
                    customer_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    allocated_doctor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    mobile = table.Column<long>(type: "bigint", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    pincode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    manufacturerID = table.Column<int>(type: "int", nullable: false),
                    manufacturer_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    manufacturer_license = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.manufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    drugID = table.Column<int>(type: "int", nullable: false),
                    stock_quantity = table.Column<int>(type: "int", nullable: false),
                    expiry_date = table.Column<DateTime>(type: "date", nullable: false),
                    manufacturer_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Stock_pk", x => x.drugID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    supplierID = table.Column<int>(type: "int", nullable: false),
                    supplier_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.supplierID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    password = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    last_login = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    drugID = table.Column<int>(type: "int", nullable: false),
                    drug_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    drug_product_type = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    supplierID = table.Column<int>(type: "int", nullable: false),
                    manufacturerID = table.Column<int>(type: "int", nullable: false),
                    drug_generic_name = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    drug_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    drug_class = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    drug_target_system = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    max_retail_price = table.Column<int>(type: "int", nullable: false),
                    purchase_price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Drugs_pk", x => new { x.drugID, x.drug_name });
                    table.ForeignKey(
                        name: "manufactures",
                        column: x => x.manufacturerID,
                        principalTable: "Manufacturer",
                        principalColumn: "manufacturerID");
                    table.ForeignKey(
                        name: "supplies",
                        column: x => x.supplierID,
                        principalTable: "Supplier",
                        principalColumn: "supplierID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false),
                    prescriptionID = table.Column<int>(type: "int", nullable: true),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    pay_date = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderID);
                    table.ForeignKey(
                        name: "gives",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "customerID");
                    table.ForeignKey(
                        name: "Order_Users",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoice",
                columns: table => new
                {
                    purchase_invoiceID = table.Column<int>(type: "int", nullable: false),
                    supplierID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    total_amount = table.Column<int>(type: "int", nullable: false),
                    payed_amount = table.Column<int>(type: "int", nullable: false),
                    remaining_amount = table.Column<int>(type: "int", nullable: false),
                    payment_type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoice", x => x.purchase_invoiceID);
                    table.ForeignKey(
                        name: "gets_paid_for",
                        column: x => x.supplierID,
                        principalTable: "Supplier",
                        principalColumn: "supplierID");
                    table.ForeignKey(
                        name: "PurchaseInvoice_Users",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID");
                });

            migrationBuilder.CreateTable(
                name: "OrderedDrugs",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false),
                    drugID = table.Column<int>(type: "int", nullable: false),
                    drug_name = table.Column<int>(type: "int", nullable: false),
                    batch_no = table.Column<int>(type: "int", nullable: false),
                    ordered_quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OrderedDrugs_pk", x => x.orderID);
                    table.ForeignKey(
                        name: "consists_of_ordered_drugs",
                        column: x => x.orderID,
                        principalTable: "Order",
                        principalColumn: "orderID");
                    table.ForeignKey(
                        name: "fulfilled_from",
                        column: x => x.drugID,
                        principalTable: "Stock",
                        principalColumn: "drugID");
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoice",
                columns: table => new
                {
                    sale_invoiceID = table.Column<int>(type: "int", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    pay_date = table.Column<DateTime>(type: "date", nullable: false),
                    total_amount = table.Column<int>(type: "int", nullable: false),
                    payment_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    discount = table.Column<int>(type: "int", nullable: false),
                    new_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoice", x => x.sale_invoiceID);
                    table.ForeignKey(
                        name: "order_generates_sale_invoice",
                        column: x => x.sale_invoiceID,
                        principalTable: "Order",
                        principalColumn: "orderID");
                    table.ForeignKey(
                        name: "pays",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "customerID");
                    table.ForeignKey(
                        name: "SaleInvoice_Users",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID");
                });

            migrationBuilder.CreateTable(
                name: "OnPurchaseInvoice",
                columns: table => new
                {
                    purchaseInvoiceID = table.Column<int>(type: "int", nullable: false),
                    drug_quantity = table.Column<int>(type: "int", nullable: false),
                    drug_purchase_total = table.Column<int>(type: "int", nullable: false),
                    batch_no = table.Column<int>(type: "int", nullable: false),
                    manufacture_ate = table.Column<DateTime>(type: "date", nullable: false),
                    expiry_date = table.Column<DateTime>(type: "date", nullable: false),
                    date_of_entry = table.Column<DateTime>(type: "date", nullable: false),
                    drug_name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OnPurchaseInvoice_pk", x => x.purchaseInvoiceID);
                    table.ForeignKey(
                        name: "consists_of_purchased_drugs",
                        column: x => x.purchaseInvoiceID,
                        principalTable: "PurchaseInvoice",
                        principalColumn: "purchase_invoiceID");
                });

            migrationBuilder.CreateTable(
                name: "OnSalesInvoice",
                columns: table => new
                {
                    on_sales_invoiceID = table.Column<int>(type: "int", nullable: false),
                    drug_name = table.Column<int>(type: "int", nullable: false),
                    drug_quantity = table.Column<int>(type: "int", nullable: false),
                    drug_price_total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnSalesInvoice", x => x.on_sales_invoiceID);
                    table.ForeignKey(
                        name: "consists_of_saled_drugs",
                        column: x => x.on_sales_invoiceID,
                        principalTable: "SaleInvoice",
                        principalColumn: "sale_invoiceID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_manufacturerID",
                table: "Drugs",
                column: "manufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_supplierID",
                table: "Drugs",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "OnPurchaseInvoice_ak",
                table: "OnPurchaseInvoice",
                column: "batch_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_customerID",
                table: "Order",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_userID",
                table: "Order",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedDrugs_drugID",
                table: "OrderedDrugs",
                column: "drugID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoice_supplierID",
                table: "PurchaseInvoice",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoice_userID",
                table: "PurchaseInvoice",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoice_customerID",
                table: "SaleInvoice",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoice_userID",
                table: "SaleInvoice",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "OnPurchaseInvoice");

            migrationBuilder.DropTable(
                name: "OnSalesInvoice");

            migrationBuilder.DropTable(
                name: "OrderedDrugs");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "PurchaseInvoice");

            migrationBuilder.DropTable(
                name: "SaleInvoice");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropSequence(
                name: "Customer_seq");

            migrationBuilder.DropSequence(
                name: "Manufacturer_seq");

            migrationBuilder.DropSequence(
                name: "PrescriptionDrugs_seq");

            migrationBuilder.DropSequence(
                name: "Supplier_seq");

            migrationBuilder.DropSequence(
                name: "Users_seq");
        }
    }
}
