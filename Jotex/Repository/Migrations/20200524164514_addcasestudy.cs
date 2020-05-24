using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class addcasestudy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseStudies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Detail = table.Column<string>(maxLength: 500, nullable: false),
                    SubDetail = table.Column<string>(maxLength: 500, nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Challenge = table.Column<string>(maxLength: 1000, nullable: false),
                    Solution = table.Column<string>(maxLength: 1000, nullable: false),
                    Result = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStudies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseStudySpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 100, nullable: false),
                    CaseStudyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStudySpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseStudySpecs_CaseStudies_CaseStudyId",
                        column: x => x.CaseStudyId,
                        principalTable: "CaseStudies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseStudySpecs_CaseStudyId",
                table: "CaseStudySpecs",
                column: "CaseStudyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseStudySpecs");

            migrationBuilder.DropTable(
                name: "CaseStudies");
        }
    }
}
