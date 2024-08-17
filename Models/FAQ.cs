namespace Models
{
    public record FAQ : BaseRecord
    {
        public string QuestionEn { get; set; } = string.Empty;
        public string QuestionAr { get; set; } = string.Empty;
        public string AnswerEn { get; set; } = string.Empty;
        public string AnswerAr { get; set; } = string.Empty;
        public Guid FAQCategoryId { get; set; }

        //Navigation Properties
        public virtual FAQCategory? FAQCategory { get; set; }
    }
}
