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
            return _context.GetAllHouseholds(_configuration);
        }
    }
}
