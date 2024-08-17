namespace Models
{
    public record ProductCategory : BaseRecord
    {
        public string CategoryNameEn { get; set; } = string.Empty;
        public string CategoryNameAr { get; set; } = string.Empty;

        //Navigation Properties
        public virtual List<Product>? Products { get; set; }
    }
}
