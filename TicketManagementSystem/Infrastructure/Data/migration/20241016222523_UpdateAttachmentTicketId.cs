using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migration
{
    /// <inheritdoc />
    public partial class UpdateAttachmentTicketId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Discussions_DiscussionId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Ticket_TicketId",
                table: "Attachments");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Attachments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DiscussionId",
                table: "Attachments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c8e33f2-787a-468c-9f87-8de892eeb152", "AQAAAAIAAYagAAAAEL5Os5vcw1k8QK1jjjXXM0EoKTwOle5C48PrDUD//jgV+y/8ZsvQHUXYY4jP+d8uJA==", "b3173d76-1676-4d81-9601-c72d6155e426" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Discussions_DiscussionId",
                table: "Attachments",
                column: "DiscussionId",
                principalTable: "Discussions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Ticket_TicketId",
                table: "Attachments",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Discussions_DiscussionId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Ticket_TicketId",
                table: "Attachments");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Attachments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiscussionId",
                table: "Attachments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "540e495c-d4c2-4243-a4f8-128b06b96d87", "AQAAAAIAAYagAAAAELEhzTh9j5dczcLm8oAnZHbWOVGSoYtyg4O1cecjBmbFjbIJjgyYtDaVjYk1XPL0qw==", "50f9e8b4-cd3c-48c8-8ce2-d38284d8ac26" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 1, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 1, new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED" });

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Discussions_DiscussionId",
                table: "Attachments",
                column: "DiscussionId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Ticket_TicketId",
                table: "Attachments",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
