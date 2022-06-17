using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class Stock
    {
        public Stock()
        {
            OrderedDrugs = new HashSet<OrderedDrug>();
        }

        public int DrugId { get; set; }
        public int StockQuantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ManufacturerName { get; set; } = null!;

        public virtual ICollection<OrderedDrug> OrderedDrugs { get; set; }
    }
}
