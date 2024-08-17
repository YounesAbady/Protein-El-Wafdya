namespace Models
{
    public record BaseRecord
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
    }
}
