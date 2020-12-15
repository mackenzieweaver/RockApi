using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RockApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Models;

namespace RockApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public BankAccountsController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<BankAccount> Get()
        {
            return _context.GetAllBankAccounts(_configuration);
        }
    }
}
