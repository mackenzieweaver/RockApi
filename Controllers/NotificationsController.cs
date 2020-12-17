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
    public class NotificationsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IConfiguration _configuration;

        public NotificationsController(ApiContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Notifications are records (emails) that are sent to the head of household.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Notification> Get()
        {
            var rawData = _context.CallPostgresFunction("getallnotificationdata");
            return (List<Notification>)JsonConvert.DeserializeObject(rawData, typeof(List<Notification>));
        }
    }
}
