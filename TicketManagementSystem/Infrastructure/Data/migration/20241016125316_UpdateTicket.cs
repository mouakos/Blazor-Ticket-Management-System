using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migration
{
    /// <inheritdoc />
    public partial class UpdateTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClosedBy",
                table: "Ticket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedDate",
                table: "Ticket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Ticket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0963b03a-0f46-4fd3-ade9-5b5e54338b05", "AQAAAAIAAYagAAAAEErr/SQbXz+Y70CJ5QMz9gHvZ6JDIgpCtkN35DYIcClDf8iTbjVannAX55bG62mZVQ==", "8b0a2dcb-59e2-4a26-8c41-5895c8c3f57d" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { null, null, null, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
                values: new object[] { 2, null, null, null, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 1, null, null, null, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "ProductId", "Status" },
                values: new object[] { 1, null, null, null, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { null, null, null, 2, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, null, null, null, 2, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, null, null, null, 3, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
                values: new object[] { null, null, null, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
                values: new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, null, null, null, 3, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate" },
                values: new object[] { 3, null, null, null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { null, null, null, 1, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
                values: new object[] { null, null, null, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { 3, null, null, null, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate" },
                values: new object[] { null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, null, null, null, 3, 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "ProductId", "Status" },
                values: new object[] { 1, null, null, null, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 2, null, null, null, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, null, null, null, 1, 1, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "Status" },
                values: new object[] { 2, null, null, null, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
                values: new object[] { 1, null, null, null, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId" },
                values: new object[] { null, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
                values: new object[] { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedBy",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ClosedDate",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Ticket");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfdd891e-5156-490f-ac35-3f10e4dd0c97", "AQAAAAIAAYagAAAAEFhfOjTwd/W/1r7pRXIbAOBfMH1mE749ARfDOZ2po3RYm3imEKH77C640WE5q7YoHA==", "3f25095d-980c-4c7a-8a70-ad1a531f134c" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PriorityId", "Status" },
                values: new object[] { 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ExpectedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ExpectedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Status" },
                values: new object[] { 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "PriorityId", "ProductId" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId" },
                values: new object[] { 2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "ProductId", "Status" },
                values: new object[] { 2, 1, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ExpectedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, 1, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, 1, 2, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, 2, 1, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                column: "Status",
                value: "CLOSED");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpectedDate", "PriorityId" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, 2, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpectedDate", "PriorityId", "Status" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ExpectedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                column: "Status",
                value: "OPEN");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "PriorityId", "Status" },
                values: new object[] { 1, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                column: "ExpectedDate",
                value: new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, 2, 3, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ProductId", "Status" },
                values: new object[] { 2, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "PriorityId", "ProductId" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
                values: new object[] { 2, 3, 2, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "PriorityId", "Status" },
                values: new object[] { 1, 1, "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "Status" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "Status" },
                values: new object[] { 3, "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ExpectedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                column: "PriorityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });
        }
    }
}
