using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Promises.Migrations
{
    public partial class InitialPromise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promise",
                columns: table => new
                {
                    PromiseId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Category = table.Column<string>(nullable: true),
                    FeedbackRating = table.Column<int>(nullable: false),
                    FinalNotes = table.Column<string>(nullable: true),
                    FulfilledDate = table.Column<DateTime>(nullable: false),
                    IsFulfilled = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    PromiseByProfileId = table.Column<Guid>(nullable: true),
                    PromiseDate = table.Column<DateTime>(nullable: false),
                    PromiseToProfileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promise", x => x.PromiseId);
                    table.ForeignKey(
                        name: "FK_Promise_Profile_PromiseByProfileId",
                        column: x => x.PromiseByProfileId,
                        principalTable: "Profile",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Promise_Profile_PromiseToProfileId",
                        column: x => x.PromiseToProfileId,
                        principalTable: "Profile",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    City = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promise_PromiseByProfileId",
                table: "Promise",
                column: "PromiseByProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Promise_PromiseToProfileId",
                table: "Promise",
                column: "PromiseToProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promise");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
