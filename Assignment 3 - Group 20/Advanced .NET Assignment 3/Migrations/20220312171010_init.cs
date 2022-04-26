using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Advanced_.NET_Assignment_3.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Immunization",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTimeOffset>(nullable: false),
                    OfficialName = table.Column<string>(maxLength: 128, nullable: false),
                    TradeName = table.Column<string>(maxLength: 128, nullable: true),
                    LotNumber = table.Column<string>(maxLength: 255, nullable: false),
                    ExpirationDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedTime = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immunization", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immunization");
        }
    }
}
