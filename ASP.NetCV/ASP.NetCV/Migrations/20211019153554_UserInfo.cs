using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NetCV.Migrations
{
    public partial class UserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEGREEMBA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXPERIENCE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAREERLEVEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAX = table.Column<int>(type: "int", nullable: false),
                    WEBSITEexample = table.Column<int>(type: "int", nullable: false),
                    CreatByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserID = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userInfos");
        }
    }
}
