using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DappingAppChat.Entities
{
	public class dbTest
	{
		[Key]
		[Column("UserId")]
		public int UserId { get; set; }

		[Column("UserName")]
		[MaxLength(200)]
		public string? UserName { get; set; }

		[Column("Password")]
		[MaxLength(255)]
		public string? Password { get; set; }
	}
}
