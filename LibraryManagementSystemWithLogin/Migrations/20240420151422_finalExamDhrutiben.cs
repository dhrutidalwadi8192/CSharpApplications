using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExamDhrutiben.Migrations
{
    public partial class finalExamDhrutiben : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    bookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.bookID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    memberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(type: "int", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.memberID);
                    table.ForeignKey(
                        name: "FK_members_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookIssue",
                columns: table => new
                {
                    bookIssueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookID = table.Column<int>(type: "int", nullable: false),
                    memberID = table.Column<int>(type: "int", nullable: false),
                    issueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    returnDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookIssue", x => x.bookIssueID);
                    table.ForeignKey(
                        name: "FK_bookIssue_books_bookID",
                        column: x => x.bookID,
                        principalTable: "books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookIssue_members_memberID",
                        column: x => x.memberID,
                        principalTable: "members",
                        principalColumn: "memberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "bookID", "author", "isAvailable", "title" },
                values: new object[,]
                {
                    { 1, "Dr. APJ Abdul Kalam", true, "Wings of Fire" },
                    { 2, "Dalai Lama", true, "The art of happiness" },
                    { 3, "Damon Zahariades", true, "The art of letting go" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userID", "password", "role", "userName" },
                values: new object[] { 1, "Admin@123", "Admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_bookIssue_bookID",
                table: "bookIssue",
                column: "bookID");

            migrationBuilder.CreateIndex(
                name: "IX_bookIssue_memberID",
                table: "bookIssue",
                column: "memberID");

            migrationBuilder.CreateIndex(
                name: "IX_members_userID",
                table: "members",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookIssue");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
