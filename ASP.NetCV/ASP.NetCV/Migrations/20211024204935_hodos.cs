using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NetCV.Migrations
{
    public partial class hodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icons_Services_ServicesId",
                table: "Icons");

            migrationBuilder.DropIndex(
                name: "IX_Icons_ServicesId",
                table: "Icons");

            migrationBuilder.DropColumn(
                name: "ServicesId",
                table: "Icons");

            migrationBuilder.CreateIndex(
                name: "IX_Icons_ServiceID",
                table: "Icons",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Icons_Services_ServiceID",
                table: "Icons",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icons_Services_ServiceID",
                table: "Icons");

            migrationBuilder.DropIndex(
                name: "IX_Icons_ServiceID",
                table: "Icons");

            migrationBuilder.AddColumn<int>(
                name: "ServicesId",
                table: "Icons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Icons_ServicesId",
                table: "Icons",
                column: "ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Icons_Services_ServicesId",
                table: "Icons",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
