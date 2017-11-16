using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Promises.Migrations
{
    public partial class InitialProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AliasName",
                table: "Alias",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Alias",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MaidenName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    ProfilePicture = table.Column<byte>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alias_ProfileId",
                table: "Alias",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Profile_ProfileId",
                table: "Alias",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Profile_ProfileId",
                table: "Alias");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Alias_ProfileId",
                table: "Alias");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Alias");

            migrationBuilder.AlterColumn<string>(
                name: "AliasName",
                table: "Alias",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
