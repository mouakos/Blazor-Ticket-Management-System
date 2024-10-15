using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.migration
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountConfirmed", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", 0, false, null, "dfdd891e-5156-490f-ac35-3f10e4dd0c97", "test@gmail.com", true, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAIAAYagAAAAEFhfOjTwd/W/1r7pRXIbAOBfMH1mE749ARfDOZ2po3RYm3imEKH77C640WE5q7YoHA==", null, false, "3f25095d-980c-4c7a-8a70-ad1a531f134c", false, "test@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Application Bug" },
                    { 2, "Network Issue" },
                    { 3, "User Issue" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "ExpectedDays", "Name" },
                values: new object[,]
                {
                    { 1, 14, "Low" },
                    { 2, 7, "Medium" },
                    { 3, 1, "High" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Product 1" },
                    { 2, "Product 2" },
                    { 3, "Product 3" }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "AssignedToId", "CategoryId", "Description", "ExpectedDate", "PriorityId", "ProductId", "RaisedBy", "RaisedDate", "Status", "Summary" },
                values: new object[,]
                {
                    { 1, null, 3, "Description for ticket 2", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 2" },
                    { 2, null, 1, "Description for ticket 3", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 3" },
                    { 3, null, 3, "Description for ticket 4", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 4" },
                    { 4, null, 2, "Description for ticket 5", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 5" },
                    { 5, null, 3, "Description for ticket 6", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 6" },
                    { 6, null, 1, "Description for ticket 7", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 7" },
                    { 7, null, 2, "Description for ticket 8", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 8" },
                    { 8, null, 3, "Description for ticket 9", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 9" },
                    { 9, null, 3, "Description for ticket 10", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 10" },
                    { 10, null, 1, "Description for ticket 11", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 11" },
                    { 11, null, 3, "Description for ticket 12", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 12" },
                    { 12, null, 1, "Description for ticket 13", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 13" },
                    { 13, null, 2, "Description for ticket 14", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 14" },
                    { 14, null, 2, "Description for ticket 15", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 15" },
                    { 15, null, 2, "Description for ticket 16", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 16" },
                    { 16, null, 2, "Description for ticket 17", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 17" },
                    { 17, null, 3, "Description for ticket 18", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 18" },
                    { 18, null, 3, "Description for ticket 19", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 19" },
                    { 19, null, 2, "Description for ticket 20", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 20" },
                    { 20, null, 2, "Description for ticket 21", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 21" },
                    { 21, null, 2, "Description for ticket 22", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 22" },
                    { 22, null, 1, "Description for ticket 23", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 23" },
                    { 23, null, 3, "Description for ticket 24", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 24" },
                    { 24, null, 1, "Description for ticket 25", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 25" },
                    { 25, null, 2, "Description for ticket 26", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 26" },
                    { 26, null, 1, "Description for ticket 27", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 27" },
                    { 27, null, 3, "Description for ticket 28", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 28" },
                    { 28, null, 3, "Description for ticket 29", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 29" },
                    { 29, null, 2, "Description for ticket 30", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 30" },
                    { 30, null, 2, "Description for ticket 31", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 31" },
                    { 31, null, 1, "Description for ticket 32", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 32" },
                    { 32, null, 2, "Description for ticket 33", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 33" },
                    { 33, null, 3, "Description for ticket 34", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 34" },
                    { 34, null, 3, "Description for ticket 35", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 35" },
                    { 35, null, 1, "Description for ticket 36", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 36" },
                    { 36, null, 3, "Description for ticket 37", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 37" },
                    { 37, null, 2, "Description for ticket 38", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 38" },
                    { 38, null, 2, "Description for ticket 39", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 39" },
                    { 39, null, 3, "Description for ticket 40", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 40" },
                    { 40, null, 2, "Description for ticket 41", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 41" },
                    { 41, null, 3, "Description for ticket 42", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 42" },
                    { 42, null, 1, "Description for ticket 43", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 43" },
                    { 43, null, 3, "Description for ticket 44", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 44" },
                    { 44, null, 1, "Description for ticket 45", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 45" },
                    { 45, null, 3, "Description for ticket 46", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 46" },
                    { 46, null, 2, "Description for ticket 47", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 47" },
                    { 47, null, 1, "Description for ticket 48", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 48" },
                    { 48, null, 3, "Description for ticket 49", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 49" },
                    { 49, null, 3, "Description for ticket 50", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 50" },
                    { 50, null, 3, "Description for ticket 51", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 51" },
                    { 51, null, 3, "Description for ticket 52", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 52" },
                    { 52, null, 2, "Description for ticket 53", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 53" },
                    { 53, null, 1, "Description for ticket 54", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 54" },
                    { 54, null, 1, "Description for ticket 55", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 55" },
                    { 55, null, 1, "Description for ticket 56", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 56" },
                    { 56, null, 3, "Description for ticket 57", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 57" },
                    { 57, null, 3, "Description for ticket 58", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 58" },
                    { 58, null, 3, "Description for ticket 59", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED", "Sample ticket 59" },
                    { 59, null, 1, "Description for ticket 60", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN", "Sample ticket 60" },
                    { 60, null, 3, "Description for ticket 61", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW", "Sample ticket 61" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
