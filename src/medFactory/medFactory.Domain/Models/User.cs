using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            SaleInvoices = new HashSet<SaleInvoice>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime LastLogin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<SaleInvoice> SaleInvoices { get; set; }
    }
}
