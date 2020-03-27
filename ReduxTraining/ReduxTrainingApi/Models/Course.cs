using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReduxTrainingApi.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Slug { get; set; }
		public int? AuthorId { get; set; }
		public string Category { get; set; }
	}

	public class RequestCourse
	{
		public int? Id { get; set; }
		public string Title { get; set; }
		public string Slug { get; set; }
		public int? AuthorId { get; set; }
		public string Category { get; set; }
	}
}
