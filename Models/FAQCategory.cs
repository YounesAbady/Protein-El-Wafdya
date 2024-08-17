namespace Models
{
    public record FAQCategory : BaseRecord
    {
        public string CategoryEn { get; set; } = string.Empty;
        public string CategoryAr { get; set; } = string.Empty;

        //Navigation Properties
        public virtual List<FAQ>? FAQs { get; set; }
    }
}
