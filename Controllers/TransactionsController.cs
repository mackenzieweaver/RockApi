using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RockApi.Data;
using RockApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public TransactionsController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Transactions are either of type withdrawal or deposit, and track how much you spend on an item within a budget (category).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return _context.GetAllTransactions(_configuration);
        }
    }
}
