using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DappingAppChat.Entities
{
	public class Users
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

		[Column("PhoneNumber")]
		[MaxLength(15)]
		public string? PhoneNumber { get; set; }

		[Column("Email")]
		[MaxLength(255)]
		public string? Email { get; set; }

		[Column("PasswordHash")]
		public byte[]? PasswordHash { get; set; }

		[Column("PasswordSalt")]
		public byte[]? PasswordSalt { get; set; }

		[Column("Active")]
		[DefaultValue(true)]
		public Boolean? Active { get; set; }

		[Column("CreateDate")]
		public DateTime? CreateDate { get; set; }

		public Users()
		{
			this.CreateDate = DateTime.Now;
			this.Active = true;
		}
	}

	//public class Users
	//{
	//	public Users()
	//	{
	//		this.CreateDate = DateTime.Now;
	//		this.Active = true;
	//	}

	//	[Key]
	//	[Column("UserId", TypeName = "INT")]
	//	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	//	public int UserId { get; set; }

	//	[Column("UserName", TypeName = "NVARCHAR(200)")]
	//	[MaxLength(200)]
	//	public string? UserName { get; set; }

	//	[Column("Password", TypeName = "NVARCHAR(255)")]
	//	[MaxLength(255)]
	//	public string? Password { get; set; }

	//	[Column("PhoneNumber", TypeName = "NVARCHAR(15)")]
	//	[MaxLength(15)]
	//	public string? PhoneNumber { get; set; }

	//	[Column("Email", TypeName = "NVARCHAR(255)")]
	//	[MaxLength(255)]
	//	public string? Email { get; set; }

	//	[Column("PasswordHash", TypeName = "VARBINARY(MAX)")]
	//	public byte[]? PasswordHash { get; set; }

	//	[Column("PasswordSalt", TypeName = "VARBINARY(MAX)")]
	//	public byte[]? PasswordSalt { get; set; }

	//	[Column("Active", TypeName = "Boolean")]
	//	[DefaultValue(true)]
	//	public Boolean Active { get; set; }

	//	[Column("CreateDate", TypeName = "DATETIME")]
	//	public DateTime CreateDate { get; set; } = DateTime.Now;
	//}
}
