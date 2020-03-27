using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReduxTrainingApi.Models;

namespace ReduxTrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
		private readonly MyDbContext DbContext;

		public AuthorsController(MyDbContext context)
		{
			DbContext = context;
		}

		// GET: api/Authers
		[HttpGet]
		public IEnumerable<Auther> Get()
		{
			return DbContext.Authers.ToList(); ;
		}

        //// GET: api/Authers/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Authers
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Authers/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
