using Quotable.Models;
using System.Net.Http.Json;

namespace Quotable.ApiClient
{
    public class QuoteClient :IQuoteClient
    {
        private readonly HttpClient _client;
        private const string RandomUrl = "/random";
        private const string QuoteUrl = "/quotes";

        public QuoteClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Quote> GetRandomQuoteAsync()
        {
            return await _client.GetFromJsonAsync<Quote>(RandomUrl);
        }
        public async Task<PagedQuotes> GetQuotesByAuthorAsync(string authorName)
        {
            var url = $"{QuoteUrl}?limit=30&author={authorName}";
            return await _client.GetFromJsonAsync<PagedQuotes>(url);
        }
    }
}
