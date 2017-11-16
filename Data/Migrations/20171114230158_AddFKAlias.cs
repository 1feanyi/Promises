using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Promises.Migrations
{
    public partial class AddFKAlias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Profile_ProfileId",
                table: "Alias");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Alias",
                newName: "EnteredByProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Alias_ProfileId",
                table: "Alias",
                newName: "IX_Alias_EnteredByProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Profile_EnteredByProfileId",
                table: "Alias",
                column: "EnteredByProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Profile_EnteredByProfileId",
                table: "Alias");

            migrationBuilder.RenameColumn(
                name: "EnteredByProfileId",
                table: "Alias",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Alias_EnteredByProfileId",
                table: "Alias",
                newName: "IX_Alias_ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Profile_ProfileId",
                table: "Alias",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
