using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StackOverflowClone.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    PostedBy = table.Column<string>(type: "TEXT", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    PostedBy = table.Column<string>(type: "TEXT", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "PostedBy", "PostedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Explain ASP.NET Core.", "Mobinul Ahasan Tanjid", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is ASP.NET Core?" },
                    { 2, "Explain EF Core.", "Mohammad Shakil", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is EF Core?" },
                    { 3, "Describe the concept of Dependency Injection and how it is implemented in ASP.NET Core.", "Joy Datta", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Dependency Injection in .NET?" },
                    { 4, "Explain what middleware is and how it works in the request pipeline.", "Rahmatullah Rony", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Middleware in ASP.NET Core?" },
                    { 5, "Discuss the layers and benefits of using Clean Architecture in .NET applications.", "Simanta Saha", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Clean Architecture?" },
                    { 6, "Explain how EF Core Migrations help in database versioning and schema updates.", "Mohammmad Noor", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Entity Framework Core Migration?" },
                    { 7, "Describe the role of controllers and actions in handling HTTP requests.", "MD Abu Taseen", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What are Controllers in ASP.NET Core MVC?" },
                    { 8, "Highlight the key differences between .NET Framework and .NET Core.", "Mobinul Ahasan Tanjid", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is the difference between .NET Framework and .NET Core?" },
                    { 9, "Explain why Data Transfer Objects are used and how they improve API design.", "Mohammad Shakil", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What are DTOs in Web API?" },
                    { 10, "Explain attribute routing and conventional routing with examples.", "Joy Datta", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Routing in ASP.NET Core?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
