using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RockApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Models;
using Newtonsoft.Json;

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

        /// <summary>
        /// Bank accounts are grouped by households, not individuals.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<BankAccount> Get()
        {
            var rawData = _context.CallPostgresFunction("getallbankaccountdata");
            return (List<BankAccount>)JsonConvert.DeserializeObject(rawData, typeof(List<BankAccount>));
        }
    }
}
