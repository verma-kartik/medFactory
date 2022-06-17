using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class SaleInvoice
    {
        public int SaleInvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public DateTime PayDate { get; set; }
        public int TotalAmount { get; set; }
        public string PaymentType { get; set; } = null!;
        public int Discount { get; set; }
        public int NewAmount { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Order SaleInvoiceNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual OnSalesInvoice OnSalesInvoice { get; set; } = null!;
    }
}
