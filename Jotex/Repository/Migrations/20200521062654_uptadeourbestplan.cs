using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class uptadeourbestplan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HilightTag",
                table: "OurBestPlans");

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "OurBestPlans",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "OurBestPlans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "LikeableAreas",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Text = table.Column<string>(maxLength: 50, nullable: false),
                    Color = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OurBestPlans_LabelId",
                table: "OurBestPlans",
                column: "LabelId");

            migrationBuilder.AddForeignKey(
                name: "FK_OurBestPlans_Labels_LabelId",
                table: "OurBestPlans",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OurBestPlans_Labels_LabelId",
                table: "OurBestPlans");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_OurBestPlans_LabelId",
                table: "OurBestPlans");

            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "OurBestPlans");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "OurBestPlans");

            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "LikeableAreas");

            migrationBuilder.AddColumn<string>(
                name: "HilightTag",
                table: "OurBestPlans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
