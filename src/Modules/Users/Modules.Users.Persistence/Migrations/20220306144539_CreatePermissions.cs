﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Persistence.Migrations
{
    public partial class CreatePermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permissions",
                schema: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissions", x => x.id);
                });

            migrationBuilder.InsertData(
                schema: "users",
                table: "permissions",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 100, "Can read user information.", "UserRead" },
                    { 101, "Can modify user information.", "UserModify" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permissions",
                schema: "users");
        }
    }
}
