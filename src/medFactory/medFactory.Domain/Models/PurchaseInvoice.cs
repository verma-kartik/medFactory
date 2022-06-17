using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class PurchaseInvoice
    {
        public int PurchaseInvoiceId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public int TotalAmount { get; set; }
        public int PayedAmount { get; set; }
        public int RemainingAmount { get; set; }
        public int PaymentType { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual OnPurchaseInvoice OnPurchaseInvoice { get; set; } = null!;
    }
}
