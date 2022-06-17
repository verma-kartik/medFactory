namespace medFactory.Domain.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            SaleInvoices = new HashSet<SaleInvoice>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string AllocatedDoctor { get; set; } = null!;
        public long Mobile { get; set; }
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Pincode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SaleInvoice> SaleInvoices { get; set; }
    }
}
