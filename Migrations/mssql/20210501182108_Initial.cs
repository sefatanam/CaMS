using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaMS.Migrations.mssql
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManufacturingYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EngineCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentPaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfRepairs = table.Column<int>(type: "int", nullable: false),
                    NumberOfAccident = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
