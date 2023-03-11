using Quotable.Models;

namespace Quotable.ApiClient
{
    public interface IQuoteClient
    {
        Task<Quote> GetRandomQuoteAsync();
        Task<PagedQuotes> GetQuotesByAuthorAsync(string authorName);
    }
}