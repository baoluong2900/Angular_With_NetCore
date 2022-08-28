using DappingAppChat.Data;
using DappingAppChat.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DappingAppChat.Controllers
{
	public class TestController : BaseApiController
	{
		private readonly DataContext _dataContext;

		public TestController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<dbTest>>> Gettest()
		{
			return await _dataContext.Tests.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<dbTest>> AddUserAsync(dbTest test)
		{
			_dataContext.Tests.Add(test);
			await _dataContext.SaveChangesAsync();
			//return await _dataContext.Users.ToListAsync();
			return test;
		}

	}
}
