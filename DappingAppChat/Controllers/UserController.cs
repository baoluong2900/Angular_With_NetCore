using DappingAppChat.Data;
using DappingAppChat.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DappingAppChat.Controllers
{
	public class UsersController : BaseApiController
	{
		private readonly DataContext _dataContext;

		public UsersController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
		{
			return await _dataContext.Users.ToListAsync();
		}

		//[HttpGet]
		//public async Task GetUsers(StreamReader streamReader, StreamWriter streamWriter)
		//{
		//	var users123 = await _dataContext.Users.ToListAsync();
		//	Table_Users test = await GetUsersLogic(users123);
		//	//return await _dataContext.Users.ToListAsync();
		//}

		//[HttpPost]
		//private async Task<object[]> GetUsersLogic(Table_Users table_Users)
		//{
		//	var list = await _dataContext.Users.ToListAsync();
		//	return new object[] { list };
		//}

		[HttpGet("{id}")]
		public async Task<ActionResult<Users>> GetUserId(int id)
		{
			return await _dataContext.Users.FindAsync(id);
		}

		[HttpPost]
		public async Task<ActionResult<Users>> AddUserAsync(Users users)
		{
			_dataContext.Users.Add(users);
			await _dataContext.SaveChangesAsync();
			//return await _dataContext.Users.ToListAsync();
			return users;
		}

	}
}
