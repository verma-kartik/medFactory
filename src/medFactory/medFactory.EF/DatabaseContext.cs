using medFactory.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace medFactory.EF
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Drug> Drugs { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<OnPurchaseInvoice> OnPurchaseInvoices { get; set; } = null!;
        public virtual DbSet<OnSalesInvoice> OnSalesInvoices { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderedDrug> OrderedDrugs { get; set; } = null!;
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; } = null!;
        public virtual DbSet<SaleInvoice> SaleInvoices { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("customerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AllocatedDoctor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("allocated_doctor");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Pincode).HasColumnName("pincode");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.HasKey(e => new { e.DrugId, e.DrugName })
                    .HasName("Drugs_pk");

                entity.Property(e => e.DrugId).HasColumnName("drugID");

                entity.Property(e => e.DrugName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("drug_name");

                entity.Property(e => e.DrugClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("drug_class");

                entity.Property(e => e.DrugGenericName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("drug_generic_name");

                entity.Property(e => e.DrugProductType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("drug_product_type");

                entity.Property(e => e.DrugTargetSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("drug_target_system");

                entity.Property(e => e.DrugType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("drug_type");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturerID");

                entity.Property(e => e.MaxRetailPrice).HasColumnName("max_retail_price");

                entity.Property(e => e.PurchasePrice).HasColumnName("purchase_price");

                entity.Property(e => e.SupplierId).HasColumnName("supplierID");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("manufactures");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("supplies");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.Property(e => e.ManufacturerId)
                    .ValueGeneratedNever()
                    .HasColumnName("manufacturerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.ManufacturerLicense)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer_license");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer_name");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<OnPurchaseInvoice>(entity =>
            {
                entity.HasKey(e => e.PurchaseInvoiceId)
                    .HasName("OnPurchaseInvoice_pk");

                entity.ToTable("OnPurchaseInvoice");

                entity.HasIndex(e => e.BatchNo, "OnPurchaseInvoice_ak")
                    .IsUnique();

                entity.Property(e => e.PurchaseInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("purchaseInvoiceID");

                entity.Property(e => e.BatchNo).HasColumnName("batch_no");

                entity.Property(e => e.DateOfEntry)
                    .HasColumnType("date")
                    .HasColumnName("date_of_entry");

                entity.Property(e => e.DrugName).HasColumnName("drug_name");

                entity.Property(e => e.DrugPurchaseTotal).HasColumnName("drug_purchase_total");

                entity.Property(e => e.DrugQuantity).HasColumnName("drug_quantity");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.ManufactureAte)
                    .HasColumnType("date")
                    .HasColumnName("manufacture_ate");

                entity.HasOne(d => d.PurchaseInvoice)
                    .WithOne(p => p.OnPurchaseInvoice)
                    .HasForeignKey<OnPurchaseInvoice>(d => d.PurchaseInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("consists_of_purchased_drugs");
            });

            modelBuilder.Entity<OnSalesInvoice>(entity =>
            {
                entity.ToTable("OnSalesInvoice");

                entity.Property(e => e.OnSalesInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("on_sales_invoiceID");

                entity.Property(e => e.DrugName).HasColumnName("drug_name");

                entity.Property(e => e.DrugPriceTotal).HasColumnName("drug_price_total");

                entity.Property(e => e.DrugQuantity).HasColumnName("drug_quantity");

                entity.HasOne(d => d.OnSalesInvoiceNavigation)
                    .WithOne(p => p.OnSalesInvoice)
                    .HasForeignKey<OnSalesInvoice>(d => d.OnSalesInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("consists_of_saled_drugs");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderID");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.PayDate).HasColumnName("pay_date");

                entity.Property(e => e.PrescriptionId).HasColumnName("prescriptionID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gives");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Order_Users");
            });

            modelBuilder.Entity<OrderedDrug>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("OrderedDrugs_pk");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderID");

                entity.Property(e => e.BatchNo).HasColumnName("batch_no");

                entity.Property(e => e.DrugId).HasColumnName("drugID");

                entity.Property(e => e.DrugName).HasColumnName("drug_name");

                entity.Property(e => e.OrderedQuantity).HasColumnName("ordered_quantity");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.OrderedDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fulfilled_from");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.OrderedDrug)
                    .HasForeignKey<OrderedDrug>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("consists_of_ordered_drugs");
            });

            modelBuilder.Entity<PurchaseInvoice>(entity =>
            {
                entity.ToTable("PurchaseInvoice");

                entity.Property(e => e.PurchaseInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("purchase_invoiceID");

                entity.Property(e => e.PayedAmount).HasColumnName("payed_amount");

                entity.Property(e => e.PaymentType).HasColumnName("payment_type");

                entity.Property(e => e.RemainingAmount).HasColumnName("remaining_amount");

                entity.Property(e => e.SupplierId).HasColumnName("supplierID");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gets_paid_for");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PurchaseInvoice_Users");
            });

            modelBuilder.Entity<SaleInvoice>(entity =>
            {
                entity.ToTable("SaleInvoice");

                entity.Property(e => e.SaleInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("sale_invoiceID");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.NewAmount).HasColumnName("new_amount");

                entity.Property(e => e.PayDate)
                    .HasColumnType("date")
                    .HasColumnName("pay_date");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("payment_type");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleInvoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pays");

                entity.HasOne(d => d.SaleInvoiceNavigation)
                    .WithOne(p => p.SaleInvoice)
                    .HasForeignKey<SaleInvoice>(d => d.SaleInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_generates_sale_invoice");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SaleInvoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SaleInvoice_Users");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.DrugId)
                    .HasName("Stock_pk");

                entity.ToTable("Stock");

                entity.Property(e => e.DrugId)
                    .ValueGeneratedNever()
                    .HasColumnName("drugID");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer_name");

                entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("supplierID");

                entity.Property(e => e.SupplierName)                   
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userID");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.HasSequence("Customer_seq");

            modelBuilder.HasSequence("Manufacturer_seq");

            modelBuilder.HasSequence("PrescriptionDrugs_seq");

            modelBuilder.HasSequence("Supplier_seq");

            modelBuilder.HasSequence("Users_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

