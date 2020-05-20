using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class FaqSettingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Settings_SettingId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_SettingId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Faqs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Faqs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "Abouts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_SettingId",
                table: "Abouts",
                column: "SettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Settings_SettingId",
                table: "Abouts",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
