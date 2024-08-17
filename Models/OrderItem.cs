namespace Models
{
    public record OrderItem : BaseRecord
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public Guid OrderId { get; set; }

        //Navigation Properties
        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
