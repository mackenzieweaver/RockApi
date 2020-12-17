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
    public class HouseholdsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public HouseholdsController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// A household is an umbrella group which contains users, categories, items, and transactions.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<HouseHold> Get()
        {
            var rawData = _context.CallPostgresFunction("getallhouseholddata");
            return (List<HouseHold>)JsonConvert.DeserializeObject(rawData, typeof(List<HouseHold>));
        }
    }
}
