﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Training.Persistence.Migrations
{
    public partial class AddInvitationSender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sender_first_name",
                schema: "training",
                table: "invitations",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sender_last_name",
                schema: "training",
                table: "invitations",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sender_first_name",
                schema: "training",
                table: "invitations");

            migrationBuilder.DropColumn(
                name: "sender_last_name",
                schema: "training",
                table: "invitations");
        }
    }
}
