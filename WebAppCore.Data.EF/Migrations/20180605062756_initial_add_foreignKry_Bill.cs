using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebAppCore.Data.EF.Migrations
{
    public partial class initial_add_foreignKry_Bill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AppUsers_CustomerId",
                table: "Bills",
                column: "CustomerId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AppUsers_CustomerId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills");
        }
    }
}
