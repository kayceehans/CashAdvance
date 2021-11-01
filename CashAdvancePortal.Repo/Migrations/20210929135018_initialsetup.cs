using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashAdvancePortal.Repo.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(nullable: true),
                    NameOfEmployee = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    DateOfRequest = table.Column<DateTime>(nullable: false),
                    DateOfApproval = table.Column<DateTime>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    SupervisorName = table.Column<string>(nullable: true),
                    RequestID = table.Column<string>(nullable: true),
                    CashAdvancePurpose = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    DateOfEnrolment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRequests");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
