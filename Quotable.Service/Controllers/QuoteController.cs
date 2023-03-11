using Microsoft.AspNetCore.Mvc;
using Quotable.Business;

namespace Quotable.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        private readonly ILogger<QuoteController> _logger;

        public QuoteController(IQuoteService quoteService,ILogger<QuoteController> logger)
        {
            _quoteService = quoteService;
            _logger = logger;
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandomQuotes()
        {
            var randomQuotes = await _quoteService.GetRandomQuoteAsync();
            return Ok(randomQuotes);
        }

        [HttpGet("by-author")]
        public async Task<IActionResult> GetQuotesByAuthorAsync()
        {
            var authorQuotes = await _quoteService.GetQuotesByAuthorAsync();
            return Ok(authorQuotes);
        }
    }
}