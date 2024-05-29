using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_demo.Migrations
{
    /// <inheritdoc />
    public partial class DateOfBirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "date_birth",
                schema: "demo",
                table: "person",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date_birth",
                schema: "demo",
                table: "person");
        }
    }
}
