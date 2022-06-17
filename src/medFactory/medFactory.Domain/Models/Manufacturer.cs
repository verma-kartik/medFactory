using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.Domain.Models
{
    public partial class Manufacturer 
    {
        public Manufacturer() => Drugs = new HashSet<Drug>();

        public int ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }
        public string? ManufacturerLicense { get; set; }
        public string? Address { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
