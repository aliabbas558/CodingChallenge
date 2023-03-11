namespace Quotable.Models
{
    public class Quote
    {
        public string _id { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public IList<string> tags { get; set; }
        public string authorSlug { get; set; }
        public int length { get; set; }
        public string dateAdded { get; set; }
        public string dateModified { get; set; }  
    }
    public class PagedQuotes
    {
        public int count { get; set; }
        public int totalCount { get; set; }
        public int page { get; set; }
        public int totalPages { get; set; }
        public ICollection<Quote> results { get; set; }
    }
    public class GroupedQuotes
    {
        public GroupedQuotes(ICollection<Quote> shortQuotes, ICollection<Quote> mediumQuotes, ICollection<Quote> longQuotes)
        {
            ShortQuotes = shortQuotes;
            MediumQuotes = mediumQuotes;
            LongQuotes = longQuotes;
        }
        public ICollection<Quote> ShortQuotes { get; set; }
        public ICollection<Quote> MediumQuotes { get; set; }
        public ICollection<Quote> LongQuotes { get; set; }
    }
}