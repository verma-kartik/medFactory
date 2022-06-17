using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? PrescriptionId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int PayDate { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual OrderedDrug OrderedDrug { get; set; } = null!;
        public virtual SaleInvoice SaleInvoice { get; set; } = null!;
    }
}
