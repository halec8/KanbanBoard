using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanban.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    PointId = table.Column<string>(nullable: false),
                    PointAmount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointId);
                });

            migrationBuilder.CreateTable(
                name: "SprintNumber",
                columns: table => new
                {
                    SprintNumberId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprintNumber", x => x.SprintNumberId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Kanbans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<string>(nullable: false),
                    StatusId = table.Column<string>(nullable: false),
                    PointId = table.Column<string>(nullable: true),
                    SprintNumberId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kanbans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kanbans_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kanbans_Points_PointId",
                        column: x => x.PointId,
                        principalTable: "Points",
                        principalColumn: "PointId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanbans_SprintNumber_SprintNumberId",
                        column: x => x.SprintNumberId,
                        principalTable: "SprintNumber",
                        principalColumn: "SprintNumberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanbans_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "work", "Work" },
                    { "home", "Home" },
                    { "ex", "Exercise" },
                    { "shop", "Shopping" },
                    { "call", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "PointId", "PointAmount" },
                values: new object[,]
                {
                    { "first", "25" },
                    { "second", "50" },
                    { "third", "75" },
                    { "fourth", "100" }
                });

            migrationBuilder.InsertData(
                table: "SprintNumber",
                columns: new[] { "SprintNumberId", "Name" },
                values: new object[,]
                {
                    { "weekthirtyeight", "Sprint 38" },
                    { "weekthirtyseven", "Sprint 37" },
                    { "weekthirtysix", "Sprint 36" },
                    { "weekthirtyfive", "Sprint 35" },
                    { "weekthirtyfour", "Sprint 34" },
                    { "weekthirty", "Sprint 30" },
                    { "weekthirtytwo", "Sprint 32" },
                    { "weekthirtyone", "Sprint 31" },
                    { "weekthirtynine", "Sprint 39" },
                    { "weektwentynine", "Sprint 29" },
                    { "weekthirtythree", "Sprint 33" },
                    { "weekforty", "Sprint 40" },
                    { "weekfortyfour", "Sprint 44" },
                    { "weekfortytwo", "Sprint 42" },
                    { "weekfortythree", "Sprint 43" },
                    { "weektwentyeight", "Sprint 28" },
                    { "weekfortyfive", "Sprint 45" },
                    { "weekfortysix", "Sprint 46" },
                    { "weekfortyseven", "Sprint 47" },
                    { "weekfortyeight", "Sprint 48" },
                    { "weekfortynine", "Sprint 49" },
                    { "weekfifty", "Sprint 50" },
                    { "weekfiftyone", "Sprint 51" },
                    { "weekfiftytwo", "Sprint 52" },
                    { "weekfortyone", "Sprint 41" },
                    { "weektwentyseven", "Sprint 27" },
                    { "weektwentyfour", "Sprint 24" },
                    { "weektwentyfive", "Sprint 25" },
                    { "weekone", "Sprint 1" },
                    { "weektwo", "Sprint 2" },
                    { "weekthree", "Sprint 3" },
                    { "weekfour", "Sprint 4" },
                    { "weekfive", "Sprint 5" },
                    { "weeksix", "Sprint 6" },
                    { "weekseven", "Sprint 7" },
                    { "weekeight", "Sprint 8" },
                    { "weeknine", "Sprint 9" },
                    { "weekten", "Sprint 10" },
                    { "weektwentysix", "Sprint 26" },
                    { "weektwelve", "Sprint 12" },
                    { "weekeleven", "Sprint 11" },
                    { "weekfourteen", "Sprint 14" },
                    { "weekfifteen", "Sprint 15" },
                    { "weeksixteen", "Sprint 16" },
                    { "weekseventeen", "Sprint 17" },
                    { "weekeighteen", "Sprint 18" },
                    { "weeknineteen", "Sprint 19" },
                    { "weektwenty", "Sprint 20" },
                    { "weektwentyone", "Sprint 21" },
                    { "weektwentytwo", "Sprint 22" },
                    { "weektwentythree", "Sprint 23" },
                    { "weekthirteen", "Sprint 13" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { "qa", "Quality Assurance (QA)" },
                    { "todo", "To do" },
                    { "inprogress", "In Progress" },
                    { "done", "Done" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kanbans_CategoryId",
                table: "Kanbans",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanbans_PointId",
                table: "Kanbans",
                column: "PointId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanbans_SprintNumberId",
                table: "Kanbans",
                column: "SprintNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanbans_StatusId",
                table: "Kanbans",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kanbans");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "SprintNumber");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
