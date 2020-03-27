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
	public class CoursesController : ControllerBase
	{
		private readonly MyDbContext DbContext;

		public CoursesController(MyDbContext context)
		{
			DbContext = context;
		}

		// GET: api/Courses
		[HttpGet]
		public IEnumerable<Course> Get()
		{
			return DbContext.Courses.ToList(); ;
		}

		//// GET: api/Courses/5
		//[HttpGet("{id}", Name = "Get")]
		//public string Get(int id)
		//{
		//    return "value";
		//}

		// POST: api/Courses
		[HttpPost]
		public Course Post([FromBody] RequestCourse value)
		{
			var max = DbContext.Courses.Max(c => c.Id);
			var newId = max + 1;

			var target = new Course()
			{
				Id = newId,
				AuthorId = value.AuthorId,
				Category = value.Category,
				Slug = newId.ToString(),
				Title = value.Title
			};

			var added = DbContext.Courses.Add(target);
			var count = DbContext.SaveChanges();

			return target;

		}

		// PUT: api/Courses/5
		[HttpPut("{id}")]
		public Course Put(int id, [FromBody] Course value)
		{
			var target = DbContext.Courses.Where(b => b.Id == id).FirstOrDefault();
			target.Title = value.Title;
			target.Slug = value.Slug;
			target.Category = value.Category;
			target.AuthorId = value.AuthorId;
			var count = DbContext.SaveChanges();
			return target;
		}

		// DELETE: api/Courses/5
		[HttpDelete("{id}")]
		public Course Delete(int id)
		{
			var target = DbContext.Courses.Where(b => b.Id == id).FirstOrDefault();
			var deleted = DbContext.Courses.Remove(target);
			var count = DbContext.SaveChanges();
			return target;
		}
	}
}
