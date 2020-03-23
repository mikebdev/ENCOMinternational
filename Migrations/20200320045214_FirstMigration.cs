using Microsoft.EntityFrameworkCore.Migrations;

namespace EncomDashboardCore.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    AppID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppType = table.Column<string>(maxLength: 15, nullable: false),
                    AppName = table.Column<string>(maxLength: 50, nullable: false),
                    AppLocation = table.Column<string>(maxLength: 100, nullable: false),
                    AppInfo = table.Column<string>(maxLength: 255, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Disabled = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.AppID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lastname = table.Column<string>(maxLength: 25, nullable: false),
                    Firstname = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 25, nullable: false),
                    AccessLevel = table.Column<int>(maxLength: 3, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Disabled = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
