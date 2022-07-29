using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DappingAppChat.Migrations
{
    public partial class creatTable : Migration
    {
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Users",
				columns: table => new
				{
					UserId = table.Column<int>(type: "INT", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					UserName = table.Column<string>(type: "NVARCHAR(200)", maxLength: 200, nullable: true),
					Password = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
					PhoneNumber = table.Column<string>(type: "NVARCHAR(15)", maxLength: 15, nullable: true),
					Email = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
					PasswordHash = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: true),
					PasswordSalt = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: true),
					Active = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true),
					CreateDate = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "getdate()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Users", x => x.UserId);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Users");
		}
	}
}
