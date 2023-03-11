

using Quotable.ApiClient;
using Quotable.Models;

namespace Quotable.Business
{
    public class QuoteService : IQuoteService
    {
        private readonly IQuoteClient _quoteClient;

        public QuoteService(IQuoteClient quoteClient)
        {
            _quoteClient = quoteClient;
        }

        public async Task<Quote> GetRandomQuoteAsync()
        {
            return await _quoteClient.GetRandomQuoteAsync();
             
        }
        public async Task<GroupedQuotes> GetQuotesByAuthorAsync()
        {
            var q = await _quoteClient.GetQuotesByAuthorAsync("albert-einstein");
            var shortQuotes = q.results.Where(x => x.length < 10).ToList();
            var mediumQuotes = q.results.Where(d => d.length >= 11 && d.length <= 20).ToList();
            var longQuotes = q.results.Where(d => d.length >20).ToList();
            var gropedQuotes = new GroupedQuotes(shortQuotes, mediumQuotes, longQuotes);
            return gropedQuotes;
        }
    }
}
