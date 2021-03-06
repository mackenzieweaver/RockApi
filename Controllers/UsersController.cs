﻿using Microsoft.AspNetCore.Http;
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
    public class UsersController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public UsersController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// A user extends microsoft's identity user and adds a few properties such as first and last name, as well as a display name.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<FPUser> Get()
        {
            var rawData = _context.CallPostgresFunction("getalluserdata");
            return (List<FPUser>)JsonConvert.DeserializeObject(rawData, typeof(List<FPUser>));
        }
    }
}
