namespace medFactory.Domain.Models
{
    public partial class Drug
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; } = null!;
        public string DrugProductType { get; set; } = null!;
        public int SupplierId { get; set; }
        public int ManufacturerId { get; set; }
        public string DrugGenericName { get; set; } = null!;
        public string DrugType { get; set; } = null!;
        public string DrugClass { get; set; } = null!;
        public string DrugTargetSystem { get; set; } = null!;
        public int MaxRetailPrice { get; set; }
        public int PurchasePrice { get; set; }

        public virtual Manufacturer Manufacturer { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
