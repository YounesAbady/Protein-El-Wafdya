namespace Models
{
    public record Product : BaseRecord
    {
        public string ProductNameEn { get; set; } = string.Empty;
        public string ProductNameAr { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        public string DescriptionAr { get; set; } = string.Empty;
        public double Price { get; set; }
        public Guid ProductCategoryId { get; set; }

        //Navigation Properties
        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual Inventory? Inventory { get; set; }
    }
}
