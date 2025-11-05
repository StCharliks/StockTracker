using DolbojebInvest.API.Dividends.Requests;
using DolbojebInvest.Domain.Dividends.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DolbojebInvest.API.Dividends.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DividendsController : ControllerBase
    {
        private readonly IDividendService _dividendService;

        public DividendsController(IDividendService dividendService)
        {
            _dividendService = dividendService;
        }

        [HttpPost]
        public async Task AddDividend(AddDividendRequest dividendRequest)
        {
            
        }
    }
}
