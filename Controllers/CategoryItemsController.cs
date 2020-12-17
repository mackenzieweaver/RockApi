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
    public class CategoryItemsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public CategoryItemsController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Specific items within a budget group (category).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<CategoryItem> Get()
        {
            var rawData = _context.CallPostgresFunction("getallcategoryitemdata");
            return (List<CategoryItem>)JsonConvert.DeserializeObject(rawData, typeof(List<CategoryItem>));
        }
    }
}
