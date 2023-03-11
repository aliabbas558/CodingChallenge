using Quotable.Models;

namespace Quotable.Business
{
    public interface IQuoteService
    {
        Task<Quote> GetRandomQuoteAsync();
        Task<GroupedQuotes> GetQuotesByAuthorAsync();
    }
}