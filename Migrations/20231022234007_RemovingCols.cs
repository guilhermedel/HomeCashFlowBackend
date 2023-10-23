using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeCashFlowBackend.Migrations
{
    /// <inheritdoc />
    public partial class RemovingCols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "costumerModels");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "costumerModels");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "costumerModels");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "costumerModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "costumerModels",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "costumerModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "costumerModels",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "costumerModels",
                type: "TEXT",
                nullable: true);
        }
    }
}
