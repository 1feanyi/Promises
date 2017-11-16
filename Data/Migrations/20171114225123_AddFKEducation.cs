using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Promises.Migrations
{
    public partial class AddFKEducation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Profile_ProfileId",
                table: "Education");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Education",
                newName: "UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Education_ProfileId",
                table: "Education",
                newName: "IX_Education_UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Profile_UserProfileId",
                table: "Education",
                column: "UserProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Profile_UserProfileId",
                table: "Education");

            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "Education",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Education_UserProfileId",
                table: "Education",
                newName: "IX_Education_ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Profile_ProfileId",
                table: "Education",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
