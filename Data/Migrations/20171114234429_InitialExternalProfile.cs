using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Promises.Migrations
{
    public partial class InitialExternalProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExternalProfile",
                columns: table => new
                {
                    ExternalProfileId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LinkedStatus = table.Column<string>(nullable: true),
                    ProviderAccountId = table.Column<string>(nullable: true),
                    ProviderAccountName = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    UserProfileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalProfile", x => x.ExternalProfileId);
                    table.ForeignKey(
                        name: "FK_ExternalProfile_Profile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "Profile",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExternalProfile_UserProfileId",
                table: "ExternalProfile",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalProfile");
        }
    }
}
