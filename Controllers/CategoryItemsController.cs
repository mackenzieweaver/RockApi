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
    public class CategoryItemsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public CategoryItemsController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<CategoryItem> Get()
        {
            return _context.GetAllCategoryItems(_configuration);
        }
    }
}
