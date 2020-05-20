using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateAbout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimActionText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "ClaimText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "OfficeActionText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "OfficeText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "PolicyActionText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "PolicyCount",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "PolicyText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "Abouts",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "Abouts",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Abouts",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "Abouts",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Abouts",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubDetail",
                table: "Abouts",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Information",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SubDetail",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "ClaimActionText",
                table: "Abouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClaimText",
                table: "Abouts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OfficeActionText",
                table: "Abouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OfficeCount",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OfficeText",
                table: "Abouts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PolicyActionText",
                table: "Abouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PolicyCount",
                table: "Abouts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PolicyText",
                table: "Abouts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Abouts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
