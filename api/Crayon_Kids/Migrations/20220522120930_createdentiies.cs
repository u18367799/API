using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crayon_Kids.Migrations
{
    public partial class createdentiies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Allergy_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Allergy_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergy_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Allergy_ID);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Assessment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assessment_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Assessment_ID);
                });

            migrationBuilder.CreateTable(
                name: "Class_Types",
                columns: table => new
                {
                    Class_Type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_Types", x => x.Class_Type_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Types",
                columns: table => new
                {
                    Employee_Type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gardener = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Administrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Principal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Types", x => x.Employee_Type_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Type_ID = table.Column<int>(type: "int", nullable: false),
                    Employee_Type_ID1 = table.Column<int>(type: "int", nullable: true),
                    School_ID = table.Column<int>(type: "int", nullable: false),
                    Title_ID = table.Column<int>(type: "int", nullable: false),
                    Employment_Status_ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact_No = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_Employee_Types_Employee_Type_ID1",
                        column: x => x.Employee_Type_ID1,
                        principalTable: "Employee_Types",
                        principalColumn: "Employee_Type_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Employee_Type_ID1",
                table: "Employees",
                column: "Employee_Type_ID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "Class_Types");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Employee_Types");
        }
    }
}
