using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyperFoxCorp.Migrations
{
    /// <inheritdoc />
    public partial class _1234576 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "LeaveApplications");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Employees");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "LeaveApplications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
