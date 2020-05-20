using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class updatelikeablemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimPercent",
                table: "Abouts");

            migrationBuilder.AlterColumn<string>(
                name: "Video",
                table: "LikeableAreas",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LikeableAreas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Information",
                table: "LikeableAreas",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<string>(
                name: "CallUs",
                table: "LikeableAreas",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CallUs",
                table: "LikeableAreas");

            migrationBuilder.AlterColumn<string>(
                name: "Video",
                table: "LikeableAreas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LikeableAreas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Information",
                table: "LikeableAreas",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AddColumn<decimal>(
                name: "ClaimPercent",
                table: "Abouts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
