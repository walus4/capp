using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capgemini.API.Migrations
{
    public partial class invoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HederId",
                table: "OrderLines",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_HederId",
                table: "OrderLines",
                column: "HederId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_OrderHeders_HederId",
                table: "OrderLines",
                column: "HederId",
                principalTable: "OrderHeders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_OrderHeders_HederId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_HederId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "HederId",
                table: "OrderLines");
        }
    }
}
