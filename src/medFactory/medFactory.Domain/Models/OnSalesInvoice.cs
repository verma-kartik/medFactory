using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class OnSalesInvoice
    {
        public int DrugName { get; set; }
        public int OnSalesInvoiceId { get; set; }
        public int DrugQuantity { get; set; }
        public int DrugPriceTotal { get; set; }

        public virtual SaleInvoice OnSalesInvoiceNavigation { get; set; } = null!;
    }
}
