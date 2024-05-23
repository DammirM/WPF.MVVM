#nullable disable

namespace GoalKeepers.Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "keepers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Crosses = table.Column<bool>(type: "bit", nullable: false),
                    GoalLine = table.Column<bool>(type: "bit", nullable: false),
                    SweeperKeeper = table.Column<bool>(type: "bit", nullable: false),
                    GoodFeet = table.Column<bool>(type: "bit", nullable: false),
                    Reflexes = table.Column<bool>(type: "bit", nullable: false),
                    AttackingKeeper = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keepers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "keepers");
        }
    }
}
