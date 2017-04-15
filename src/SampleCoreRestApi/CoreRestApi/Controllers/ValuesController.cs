using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CoreRestApi.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		// GET api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "Brennan", "Declan", "Brielle", "Ian Connor" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			switch (id) {
				case 1:
					return "One";
				case 6:
					return "Brennan";
				case 8:
					return "Declan!";
				case 10:
					return "Brielle";
				case 11:
					return "Big bad Ian";
				case 40:
					return "Mama";
				case 44:
					return "Dada";
				default:
					return "I don't know.";
			}
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
