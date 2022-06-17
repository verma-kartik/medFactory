using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Drugs = new HashSet<Drug>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
        }

        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }    
        public long Phone { get; set; }
        public string Address { get; set; } = null!;

        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
    }
}
