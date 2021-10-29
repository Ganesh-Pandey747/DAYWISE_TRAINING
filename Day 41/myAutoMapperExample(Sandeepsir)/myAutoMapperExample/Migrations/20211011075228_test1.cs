using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myAutoMapperExample.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AddedDate", "Email", "IPAddress", "Password", "UserName", "modifyDate" },
                values: new object[] { 123, new DateTime(2021, 10, 11, 7, 52, 28, 136, DateTimeKind.Utc).AddTicks(7820), "sandeep@gmail.com", "56678", "test123", "sandeep", new DateTime(2021, 10, 11, 7, 52, 28, 136, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AddedDate", "Email", "IPAddress", "Password", "UserName", "modifyDate" },
                values: new object[] { 163, new DateTime(2021, 10, 11, 7, 52, 28, 137, DateTimeKind.Utc).AddTicks(9294), "sandeep23@gmail.com", "56678", "test789", "sandeep karan", new DateTime(2021, 10, 11, 7, 52, 28, 137, DateTimeKind.Utc).AddTicks(9300) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
