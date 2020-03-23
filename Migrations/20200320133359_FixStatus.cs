using Microsoft.EntityFrameworkCore.Migrations;

namespace EncomDashboardCore.Migrations
{
    public partial class FixStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Disabled",
                table: "Applications");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Disabled",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disabled",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
