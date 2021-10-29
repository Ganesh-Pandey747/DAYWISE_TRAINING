using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Usermanagement1.Migrations
{
    public partial class Phase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifyDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IPAddress = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifyDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IPAddress = table.Column<string>(type: "text", nullable: true)
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
                values: new object[,]
                {
                    { 123, new DateTime(2021, 10, 11, 7, 49, 59, 484, DateTimeKind.Utc).AddTicks(1519), "sandeep@gmail.com", "56678", "test123", "sandeep", new DateTime(2021, 10, 11, 7, 49, 59, 484, DateTimeKind.Utc).AddTicks(2395) },
                    { 163, new DateTime(2021, 10, 11, 7, 49, 59, 485, DateTimeKind.Utc).AddTicks(5374), "sandeep23@gmail.com", "56678", "test789", "sandeep karan", new DateTime(2021, 10, 11, 7, 49, 59, 485, DateTimeKind.Utc).AddTicks(5379) }
                });
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
