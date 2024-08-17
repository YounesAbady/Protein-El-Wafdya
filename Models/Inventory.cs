namespace Models
{
    public record Inventory : BaseRecord
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } = 0;
        public DateTime LastUpdated { get; set; }

        //Navigation Properties
        public virtual Product? Product { get; set; }
    }
}
