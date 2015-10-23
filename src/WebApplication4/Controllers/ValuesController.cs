using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var allItems = new ItemContext().GetAll();
            return allItems;
        }
    }
}
