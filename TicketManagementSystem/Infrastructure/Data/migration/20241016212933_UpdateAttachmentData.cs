#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.migration;

/// <inheritdoc />
public partial class UpdateAttachmentData : Migration
{
    #region Protected methods declaration

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            "AspNetUsers",
            "Id",
            "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
            new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            new object[]
            {
                "30cd18c1-3848-428f-a566-1d17ed2526fd",
                "AQAAAAIAAYagAAAAEG2j3PpDRdLrZs7TaWiuvwLX5J7DAZxFE3WeXqGapwhfIjg5zOxCZuju+0LpMDCNEw==",
                "a90b72ce-b55e-43a8-9ee7-aee9819253d9"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });
    }

    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            "AspNetUsers",
            "Id",
            "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
            new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            new object[]
            {
                "540e495c-d4c2-4243-a4f8-128b06b96d87",
                "AQAAAAIAAYagAAAAELEhzTh9j5dczcLm8oAnZHbWOVGSoYtyg4O1cecjBmbFjbIJjgyYtDaVjYk1XPL0qw==",
                "50f9e8b4-cd3c-48c8-8ce2-d38284d8ac26"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 1,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });
    }

    #endregion
}