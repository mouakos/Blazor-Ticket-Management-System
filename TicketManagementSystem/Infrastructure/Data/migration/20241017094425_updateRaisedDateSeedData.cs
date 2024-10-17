using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migration
{
    /// <inheritdoc />
    public partial class updateRaisedDateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(3916), new DateTime(2024, 4, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), new DateTime(2024, 6, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), 2, new DateTime(2024, 5, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5985), 3, new DateTime(2024, 9, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5985), "OPEN" });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), new DateTime(2024, 7, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), 3, 3, new DateTime(2024, 7, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), new DateTime(2024, 5, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), 3, new DateTime(2024, 5, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 5, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6054), 3, 3, new DateTime(2024, 5, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6054), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 2, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6067), 3, 1, new DateTime(2024, 2, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 1, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6080), 3, 1, new DateTime(2024, 1, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6080), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 8, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6091), 1, new DateTime(2024, 8, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 2, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6130), new DateTime(2024, 2, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6130), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 2, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143), new DateTime(2024, 2, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143), 1, 3, new DateTime(2024, 2, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 9, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6155), 3, new DateTime(2024, 8, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6155), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 4, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6166), 2, 2, new DateTime(2024, 4, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6166), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178), new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178), 2, 2, new DateTime(2024, 3, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191), new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191), 3, new DateTime(2024, 6, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203), new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203), 3, 1, new DateTime(2024, 6, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6215), 1, 2, new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), new DateTime(2024, 10, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), 2, 3, new DateTime(2024, 10, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6254), 3, new DateTime(2024, 10, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6254), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 3, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267), new DateTime(2024, 3, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267), 3, new DateTime(2024, 3, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 8, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6279), 1, 2, new DateTime(2024, 8, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6279), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), 2, 2, new DateTime(2024, 4, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), "CLOSED" });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), new DateTime(2024, 6, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), 2, 3, new DateTime(2024, 6, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 4, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6327), new DateTime(2024, 4, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6327), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), new DateTime(2024, 6, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), new DateTime(2024, 6, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350), new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350), 3, new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), 3, 2, new DateTime(2024, 4, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6418), new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6418), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), new DateTime(2024, 3, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), 3, new DateTime(2024, 3, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), "CLOSED" });

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
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 6, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6453), 3, new DateTime(2024, 6, 7, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6453), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 3, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6465), 2, new DateTime(2024, 2, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6465), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6477), 1, new DateTime(2024, 6, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6477), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 3, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488), new DateTime(2024, 3, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488), 2, new DateTime(2024, 3, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6501), 3, 3, new DateTime(2024, 3, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 7, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6542), 2, 3, new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6542), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6554), 3, new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6554), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 7, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566), new DateTime(2024, 7, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566), 3, new DateTime(2024, 7, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), 3, new DateTime(2024, 7, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 8, 27, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6590), 3, 3, new DateTime(2024, 8, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 1, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6602), 1, 3, new DateTime(2024, 1, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6602), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 6, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6613), new DateTime(2024, 5, 31, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625), new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625), 2, 3, new DateTime(2024, 5, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 9, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6638), 3, new DateTime(2024, 9, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6638), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6673), 2, new DateTime(2024, 10, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6673), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 5, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6685), 1, 2, new DateTime(2024, 5, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6685), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 1, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6697), 3, new DateTime(2024, 1, 12, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6697), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 3, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6709), 2, new DateTime(2024, 3, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6709), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), new DateTime(2024, 6, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), 2, new DateTime(2024, 6, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6733), 1, new DateTime(2024, 10, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6733), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 6, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6745), 2, new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6745), "NEW" });

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
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795), new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795), 2, 1, new DateTime(2024, 3, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6810), 1, new DateTime(2024, 5, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6810), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 7, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6821), 2, 1, new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6821), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6833), 3, new DateTime(2024, 9, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6844), 1, 1, new DateTime(2024, 6, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6844), "OPEN" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

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
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

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
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

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
                columns: new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
                values: new object[] { 2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
                values: new object[] { 3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

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
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

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
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 1, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

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
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
                values: new object[] { 1, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3, new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW" });
        }
    }
}
