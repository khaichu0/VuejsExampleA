using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiNetCore6.Migrations
{
    public partial class createForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequireCaptcha = table.Column<bool>(type: "bit", nullable: true),
                    RequireLogin = table.Column<bool>(type: "bit", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    IsLimitToOne = table.Column<bool>(type: "bit", nullable: true),
                    MaxNumResponse = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropColumn(
                name: "AvatarImage",
                table: "AspNetUsers");
        }
    }
}
