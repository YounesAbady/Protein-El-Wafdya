namespace Models
{
    public record Order : BaseRecord
    {
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }

        //Navigation Properties
        //public virtual Customer? Customer { get; set; }
        public virtual List<OrderItem>? OrderItems { get; set; }
    }
}
