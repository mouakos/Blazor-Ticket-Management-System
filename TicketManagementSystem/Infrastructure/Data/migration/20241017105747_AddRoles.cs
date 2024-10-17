using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.migration
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48395b9b-a292-4a48-80df-ebc6a057f6c0", null, "Admin", "ADMIN" },
                    { "6367a40d-3014-43bc-a704-135f41abae2d", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                columns: new[] { "ConcurrencyStamp", "IsDeleted", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99afd884-14e0-4350-a388-30e5b0fe9fb6", false, "AQAAAAIAAYagAAAAECtGJNAruPxhwhiAfQVtpv4MkhUQGJAlsI29XUOzyVy1keaDI2jqO5mrEmdy4K89PQ==", "a9366ac3-aa68-4cca-b9e2-ac823a9a69a3" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 10, 12, 57, 46, 682, DateTimeKind.Unspecified).AddTicks(9585), 1, 3, new DateTime(2024, 9, 3, 12, 57, 46, 682, DateTimeKind.Unspecified).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 3, 26, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1430), 2, 3, new DateTime(2024, 3, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1430), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 28, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1475), new DateTime(2024, 8, 28, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1475), 2, 1, new DateTime(2024, 8, 14, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1475), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1495), new DateTime(2024, 9, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1495), 1, 1, new DateTime(2024, 9, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1495), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 5, 18, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1508), 3, new DateTime(2024, 5, 11, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1508), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 1, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1520), 2, 1, new DateTime(2024, 1, 6, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1520), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1532), new DateTime(2024, 9, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1532), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 3, 31, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1544), 1, 1, new DateTime(2024, 3, 17, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1544), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1556), 2, 3, new DateTime(2024, 8, 16, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1556), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1568), 3, new DateTime(2024, 3, 30, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1568), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1606), 2, 2, new DateTime(2024, 3, 19, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1620), 2, 2, new DateTime(2024, 6, 4, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 8, 10, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1631), 3, 1, new DateTime(2024, 7, 27, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1631), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 6, 3, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1643), 2, 1, new DateTime(2024, 5, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1643), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 7, 21, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1655), 3, 1, new DateTime(2024, 7, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1655), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 3, 15, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1666), new DateTime(2024, 3, 14, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1666), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 2, 27, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1677), new DateTime(2024, 2, 27, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1677), 2, 3, new DateTime(2024, 2, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 3, 27, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1690), new DateTime(2024, 3, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1690), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 2, 5, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1702), 2, 3, new DateTime(2024, 2, 4, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1702), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 5, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1751), 3, new DateTime(2024, 4, 29, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1751), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 1, 19, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1763), 2, 1, new DateTime(2024, 1, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 5, 10, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1775), 1, new DateTime(2024, 5, 3, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1775), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 1, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1786), 2, new DateTime(2024, 1, 6, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1786), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 2, 29, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1798), 3, new DateTime(2024, 2, 28, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1798), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 7, 31, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1809), 3, 2, new DateTime(2024, 7, 30, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1809), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 5, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1821), 1, new DateTime(2024, 4, 25, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1821), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 1, 14, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1833), 3, 2, new DateTime(2024, 1, 7, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 2, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1844), 3, new DateTime(2024, 2, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1844), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 4, 16, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1888), 2, new DateTime(2024, 4, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1888), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 21, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1901), new DateTime(2024, 10, 7, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1901), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 5, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1912), new DateTime(2024, 3, 5, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1912), 3, 3, new DateTime(2024, 2, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1912), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 2, 15, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1924), 1, 1, new DateTime(2024, 2, 14, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1924), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1935), new DateTime(2024, 3, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1935), 2, new DateTime(2024, 2, 24, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1935), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 22, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1947), new DateTime(2024, 2, 22, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1947), 2, 2, new DateTime(2024, 2, 8, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1947), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 7, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1959), 2, 3, new DateTime(2024, 7, 5, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1959), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 3, 26, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1970), 3, new DateTime(2024, 3, 25, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1970), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 22, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1981), new DateTime(2024, 9, 22, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1981), 3, new DateTime(2024, 9, 15, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 5, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2010), 1, new DateTime(2024, 5, 8, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2010), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 1, 28, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2022), 3, 2, new DateTime(2024, 1, 21, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2022), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2034), 1, 2, new DateTime(2024, 7, 25, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2034), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 7, 30, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2045), 1, new DateTime(2024, 7, 16, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2045), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 1, 19, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2056), 3, 2, new DateTime(2024, 1, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2056), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 10, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2068), new DateTime(2024, 3, 10, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2068), 2, new DateTime(2024, 3, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2068), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 4, 19, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2081), 1, new DateTime(2024, 4, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 7, 31, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2092), 3, 3, new DateTime(2024, 7, 17, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 3, 11, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2104), 3, new DateTime(2024, 3, 4, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2104), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 20, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2163), 1, new DateTime(2024, 9, 19, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 7, 3, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2175), 1, new DateTime(2024, 7, 2, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 6, 28, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2186), 3, 1, new DateTime(2024, 6, 27, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 3, 23, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2198), 1, 3, new DateTime(2024, 3, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 7, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2209), new DateTime(2024, 7, 8, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2209), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 8, 10, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2220), 1, new DateTime(2024, 8, 3, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2220), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 4, 23, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2232), 3, new DateTime(2024, 4, 16, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2232), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 7, 21, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2243), 3, 3, new DateTime(2024, 7, 7, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 9, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2255), 3, 1, new DateTime(2024, 9, 25, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 8, 23, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2308), new DateTime(2024, 8, 23, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2308), 3, new DateTime(2024, 8, 22, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2321), new DateTime(2024, 1, 13, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2321), 3, new DateTime(2024, 1, 12, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2321), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 14, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2332), 3, new DateTime(2024, 9, 7, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2332), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 4, 4, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2344), new DateTime(2024, 3, 28, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2355), 3, 2, new DateTime(2024, 7, 23, 12, 57, 46, 683, DateTimeKind.Unspecified).AddTicks(2355) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48395b9b-a292-4a48-80df-ebc6a057f6c0", "c5e57a7f-39e8-4007-940e-4468dfbb04f3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6367a40d-3014-43bc-a704-135f41abae2d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48395b9b-a292-4a48-80df-ebc6a057f6c0", "c5e57a7f-39e8-4007-940e-4468dfbb04f3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48395b9b-a292-4a48-80df-ebc6a057f6c0");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ab4d49-0693-40f2-b361-f18d7d45ef88", "AQAAAAIAAYagAAAAEH+XNJ52O8wW/bXpoO9CUO/Fprl8AnZUhO70sOd0yWJY0umgtY66o9A3I3aQua62/Q==", "a67d869d-6eb9-4aaa-89d4-eb04a8140c24" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(3916), 3, 1, new DateTime(2024, 4, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), new DateTime(2024, 6, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), 3, 2, new DateTime(2024, 5, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5985), 3, 3, new DateTime(2024, 9, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5985), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 5, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6003), 3, 2, new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6003), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6016), new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6016), 1, new DateTime(2024, 6, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6016), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), new DateTime(2024, 7, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), 3, 3, new DateTime(2024, 7, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), new DateTime(2024, 5, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), new DateTime(2024, 5, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 5, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6054), 3, 3, new DateTime(2024, 5, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6054), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 2, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6067), 3, 1, new DateTime(2024, 2, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6067), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6080), 1, new DateTime(2024, 1, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6080), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 8, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6091), 1, 3, new DateTime(2024, 8, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6130), 1, 3, new DateTime(2024, 2, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143), new DateTime(2024, 2, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143), 1, 3, new DateTime(2024, 2, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6155), 3, 2, new DateTime(2024, 8, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6155), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 4, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6166), 2, 2, new DateTime(2024, 4, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6166), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178), new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178), new DateTime(2024, 3, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191), new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191), 3, 2, new DateTime(2024, 6, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203), new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203), new DateTime(2024, 6, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6215), 1, 2, new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6215), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), new DateTime(2024, 10, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), 2, new DateTime(2024, 10, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6254), 1, 3, new DateTime(2024, 10, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267), new DateTime(2024, 3, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267), 3, new DateTime(2024, 3, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 8, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6279), 1, new DateTime(2024, 8, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6279), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), 2, new DateTime(2024, 4, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6303), new DateTime(2024, 1, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6303), 2, 1, new DateTime(2024, 1, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6303), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), new DateTime(2024, 6, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), 2, new DateTime(2024, 6, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 4, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6327), 2, 1, new DateTime(2024, 4, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), new DateTime(2024, 6, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), 2, new DateTime(2024, 6, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350), new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350), 3, new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), new DateTime(2024, 4, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6418), 1, 1, new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6418), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), new DateTime(2024, 3, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), 3, 3, new DateTime(2024, 3, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6442), 1, new DateTime(2024, 8, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6442), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 6, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6453), 3, 3, new DateTime(2024, 6, 7, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6453), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6465), 3, 2, new DateTime(2024, 2, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6465), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 7, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6477), 1, new DateTime(2024, 6, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6477), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 3, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488), new DateTime(2024, 3, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488), 2, new DateTime(2024, 3, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6501), 3, new DateTime(2024, 3, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6501), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 7, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6542), 2, 3, new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6542), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6554), 2, 3, new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6554), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566), new DateTime(2024, 7, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566), 3, new DateTime(2024, 7, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), 1, 3, new DateTime(2024, 7, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 8, 27, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6590), 3, new DateTime(2024, 8, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6590), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6602), 3, new DateTime(2024, 1, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 6, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6613), 2, 2, new DateTime(2024, 5, 31, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625), new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625), 2, new DateTime(2024, 5, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6638), 3, new DateTime(2024, 9, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6673), 3, new DateTime(2024, 10, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6685), 1, 2, new DateTime(2024, 5, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 1, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6697), 3, 1, new DateTime(2024, 1, 12, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 3, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6709), new DateTime(2024, 3, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6709), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), new DateTime(2024, 6, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), 3, new DateTime(2024, 6, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6733), 1, new DateTime(2024, 10, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6733), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 6, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6745), 2, 2, new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 7, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6757), 1, 2, new DateTime(2024, 7, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795), new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795), 2, new DateTime(2024, 3, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6810), 1, new DateTime(2024, 5, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6810), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 7, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6821), 2, new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6821), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6833), new DateTime(2024, 9, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6844), 1, 1, new DateTime(2024, 6, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6844) });
        }
    }
}
