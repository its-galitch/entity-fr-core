﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 30, 11, 44, 57, 320, DateTimeKind.Unspecified).AddTicks(2302), "Tivoli Gardens FC" },
                    { 2, new DateTime(2025, 9, 30, 11, 44, 57, 320, DateTimeKind.Unspecified).AddTicks(3213), "Waterhouse F.C." },
                    { 3, new DateTime(2025, 9, 30, 11, 44, 57, 320, DateTimeKind.Unspecified).AddTicks(3221), "Humble Lions F.C." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3);
        }
    }
}
