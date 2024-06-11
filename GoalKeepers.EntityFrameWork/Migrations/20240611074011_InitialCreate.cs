using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoalKeepers.EntityFrameWork.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoalKeeperViewers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crosses = table.Column<bool>(type: "bit", nullable: false),
                    GoalLineKeeper = table.Column<bool>(type: "bit", nullable: false),
                    SweeperKeeper = table.Column<bool>(type: "bit", nullable: false),
                    GoodWithFeet = table.Column<bool>(type: "bit", nullable: false),
                    Reflexes = table.Column<bool>(type: "bit", nullable: false),
                    AttackingKeeper = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalKeeperViewers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoalKeeperViewers");
        }
    }
}
