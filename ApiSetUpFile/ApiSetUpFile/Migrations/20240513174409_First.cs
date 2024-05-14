using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSetUpFile.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    E_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    E_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_age = table.Column<int>(type: "int", nullable: true),
                    E_DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    E_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    E_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.E_Id);
                });

            migrationBuilder.CreateTable(
                name: "E_Address",
                columns: table => new
                {
                    DoorNum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    E_Id = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeE_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_Address", x => x.DoorNum);
                    table.ForeignKey(
                        name: "FK_E_Address_Employee_EmployeeE_Id",
                        column: x => x.EmployeeE_Id,
                        principalTable: "Employee",
                        principalColumn: "E_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_E_Address_EmployeeE_Id",
                table: "E_Address",
                column: "EmployeeE_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "E_Address");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
