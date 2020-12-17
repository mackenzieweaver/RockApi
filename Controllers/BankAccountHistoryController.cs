using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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
    public class BankAccountHistoryController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;
        public BankAccountHistoryController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// There is one Bank Account History record per day, per account, minimum.
        /// </summary>
        [HttpGet]
        public IEnumerable<History> Get()
        {
            var rawData = _context.CallPostgresFunction("getallbankaccounthistory");
            return (List<History>)JsonConvert.DeserializeObject(rawData, typeof(List<History>));
        }
    }
}
