using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Advanced_.NET_Assignment_3.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Immunization",
                table: "Immunization");

            migrationBuilder.RenameTable(
                name: "Immunization",
                newName: "Entity");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedTime",
                table: "Entity",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<string>(
                name: "OfficialName",
                table: "Entity",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LotNumber",
                table: "Entity",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ExpirationDate",
                table: "Entity",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Entity",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Entity",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Entity",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Entity",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LicenseNumber",
                table: "Entity",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entity",
                table: "Entity",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entity",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "LicenseNumber",
                table: "Entity");

            migrationBuilder.RenameTable(
                name: "Entity",
                newName: "Immunization");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedTime",
                table: "Immunization",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficialName",
                table: "Immunization",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LotNumber",
                table: "Immunization",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ExpirationDate",
                table: "Immunization",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Immunization",
                table: "Immunization",
                column: "Id");
        }
    }
}
