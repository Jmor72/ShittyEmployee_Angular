using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ShittyEmployee_Angular.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    address = table.Column<string>(nullable: true),
                    department = table.Column<string>(nullable: true),
                    employed = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    salary = table.Column<int>(nullable: false),
                    supervisor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Employee");
        }
    }
}
