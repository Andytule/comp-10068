using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Advanced_.NET_Assignment_3.Migrations
{
    public partial class patients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateOfBirth",
                table: "Entity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Entity");
        }
    }
}
