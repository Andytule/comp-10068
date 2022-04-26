using Microsoft.EntityFrameworkCore.Migrations;

namespace Advanced_.NET_Assignment_3.Migrations
{
    public partial class initorg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Entity",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Entity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provider_Address",
                table: "Entity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Provider_Address",
                table: "Entity");
        }
    }
}
