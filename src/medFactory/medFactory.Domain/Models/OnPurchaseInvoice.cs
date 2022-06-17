using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class OnPurchaseInvoice
    {
        public int PurchaseInvoiceId { get; set; }
        public int DrugQuantity { get; set; }
        public int DrugPurchaseTotal { get; set; }
        public int BatchNo { get; set; }
        public DateTime ManufactureAte { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime DateOfEntry { get; set; }
        public int DrugName { get; set; }

        public virtual PurchaseInvoice PurchaseInvoice { get; set; } = null!;
    }
}
