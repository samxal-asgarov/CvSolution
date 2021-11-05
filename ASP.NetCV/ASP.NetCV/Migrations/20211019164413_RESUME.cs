using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NetCV.Migrations
{
    public partial class RESUME : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BioSkilsInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserID = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BioSkilsInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expirences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpierenceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirenceWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirenceLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpierenceDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserID = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expirences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserID = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkils", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BioSkilsInfos");

            migrationBuilder.DropTable(
                name: "Expirences");

            migrationBuilder.DropTable(
                name: "ResumeSkils");
        }
    }
}
