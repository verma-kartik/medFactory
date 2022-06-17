using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class OrderedDrug
    {
        public int OrderId { get; set; }
        public int DrugId { get; set; }
        public int DrugName { get; set; }
        public int BatchNo { get; set; }
        public int OrderedQuantity { get; set; }
        public int Price { get; set; }

        public virtual Stock Drug { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
