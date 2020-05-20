using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Abouts_AboutUsId",
                table: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Agents_AboutUsId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "AboutUsId",
                table: "Agents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutUsId",
                table: "Agents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agents_AboutUsId",
                table: "Agents",
                column: "AboutUsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Abouts_AboutUsId",
                table: "Agents",
                column: "AboutUsId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
