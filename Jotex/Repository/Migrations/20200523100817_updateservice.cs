using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class updateservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSpecs_ServiceDetails_ServiceDetailId",
                table: "ServiceSpecs");

            migrationBuilder.DropIndex(
                name: "IX_ServiceSpecs_ServiceDetailId",
                table: "ServiceSpecs");

            migrationBuilder.DropColumn(
                name: "ServiceDetailId",
                table: "ServiceSpecs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceDetailId",
                table: "ServiceSpecs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpecs_ServiceDetailId",
                table: "ServiceSpecs",
                column: "ServiceDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSpecs_ServiceDetails_ServiceDetailId",
                table: "ServiceSpecs",
                column: "ServiceDetailId",
                principalTable: "ServiceDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
