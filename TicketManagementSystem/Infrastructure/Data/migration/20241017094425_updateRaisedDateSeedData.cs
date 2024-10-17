#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.migration;

/// <inheritdoc />
public partial class updateRaisedDateSeedData : Migration
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
                "2c8e33f2-787a-468c-9f87-8de892eeb152",
                "AQAAAAIAAYagAAAAEL5Os5vcw1k8QK1jjjXXM0EoKTwOle5C48PrDUD//jgV+y/8ZsvQHUXYY4jP+d8uJA==",
                "b3173d76-1676-4d81-9601-c72d6155e426"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[] { "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
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
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
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
                "04ab4d49-0693-40f2-b361-f18d7d45ef88",
                "AQAAAAIAAYagAAAAEH+XNJ52O8wW/bXpoO9CUO/Fprl8AnZUhO70sOd0yWJY0umgtY66o9A3I3aQua62/Q==",
                "a67d869d-6eb9-4aaa-89d4-eb04a8140c24"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[] { "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 5, 1, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(3916),
                new DateTime(2024, 4, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(3916)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 6, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899),
                new DateTime(2024, 6, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), 2,
                new DateTime(2024, 5, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5899), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5985), 3,
                new DateTime(2024, 9, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(5985), "OPEN"
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
                1, null, null, new DateTime(2024, 5, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6003), 3,
                2, new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6003), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6016),
                new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6016), 1,
                new DateTime(2024, 6, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6016), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 7, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029),
                new DateTime(2024, 7, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), 3, 3,
                new DateTime(2024, 7, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6029), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 5, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042),
                new DateTime(2024, 5, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), 3,
                new DateTime(2024, 5, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6042), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, null, null, new DateTime(2024, 5, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6054), 3,
                3, new DateTime(2024, 5, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6054), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 2, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6067), 3, 1,
                new DateTime(2024, 2, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6067)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 1, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6080), 3, 1,
                new DateTime(2024, 1, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6080), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 8, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6091), 1,
                new DateTime(2024, 8, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6091)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 2, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6130),
                new DateTime(2024, 2, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6130), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 2, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143),
                new DateTime(2024, 2, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143), 1, 3,
                new DateTime(2024, 2, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6143)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6155), 3,
                new DateTime(2024, 8, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6155), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 4, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6166), 2, 2,
                new DateTime(2024, 4, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6166), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178),
                new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178), 2, 2,
                new DateTime(2024, 3, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6178)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191),
                new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191), 3,
                new DateTime(2024, 6, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6191)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203),
                new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203), 3, 1,
                new DateTime(2024, 6, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6203)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6215), 1, 2,
                new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6215)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227),
                new DateTime(2024, 10, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), 2, 3,
                new DateTime(2024, 10, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6227), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6254), 3,
                new DateTime(2024, 10, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6254), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 3, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267),
                new DateTime(2024, 3, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267), 3,
                new DateTime(2024, 3, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6267)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 8, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6279), 1,
                2, new DateTime(2024, 8, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6279), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291),
                new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), 2, 2,
                new DateTime(2024, 4, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6291), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 1, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6303),
                new DateTime(2024, 1, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6303), 2, 1,
                new DateTime(2024, 1, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6303), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 6, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315),
                new DateTime(2024, 6, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), 2, 3,
                new DateTime(2024, 6, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6315), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 4, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6327),
                new DateTime(2024, 4, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6327), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 6, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338),
                new DateTime(2024, 6, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338),
                new DateTime(2024, 6, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6338), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350),
                new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350), 3,
                new DateTime(2024, 4, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6350)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405),
                new DateTime(2024, 5, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), 3, 2,
                new DateTime(2024, 4, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6405), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6418),
                new DateTime(2024, 9, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6418), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 3, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430),
                new DateTime(2024, 3, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), 3,
                new DateTime(2024, 3, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6430), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 9, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6442), 1,
                new DateTime(2024, 8, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6442), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 6, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6453), 3,
                new DateTime(2024, 6, 7, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6453), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 3, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6465), 2,
                new DateTime(2024, 2, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6465), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 7, 6, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6477), 1,
                new DateTime(2024, 6, 29, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6477), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 3, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488),
                new DateTime(2024, 3, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488), 2,
                new DateTime(2024, 3, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6488)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 4, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6501), 3, 3,
                new DateTime(2024, 3, 28, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6501)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 7, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6542), 2, 3,
                new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6542), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 5, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6554), 3,
                new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6554), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 7, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566),
                new DateTime(2024, 7, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566), 3,
                new DateTime(2024, 7, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6566)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578),
                new DateTime(2024, 7, 22, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), 3,
                new DateTime(2024, 7, 21, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6578), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 8, 27, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6590), 3, 3,
                new DateTime(2024, 8, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6590)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 1, 23, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6602), 1,
                3, new DateTime(2024, 1, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6602), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 6, 14, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6613),
                new DateTime(2024, 5, 31, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6613)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625),
                new DateTime(2024, 5, 25, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625), 2, 3,
                new DateTime(2024, 5, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6625)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 9, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6638), 3,
                new DateTime(2024, 9, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6638), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6673), 2,
                new DateTime(2024, 10, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6673), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 5, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6685), 1, 2,
                new DateTime(2024, 5, 2, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6685), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 1, 26, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6697), 3,
                new DateTime(2024, 1, 12, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6697), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 3, 20, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6709), 2,
                new DateTime(2024, 3, 13, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6709), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 6, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720),
                new DateTime(2024, 6, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), 2,
                new DateTime(2024, 6, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6720), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6733), 1,
                new DateTime(2024, 10, 3, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6733), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 6, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6745), 2,
                new DateTime(2024, 6, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6745), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 7, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6757), 1, 2,
                new DateTime(2024, 7, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6757)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795),
                new DateTime(2024, 3, 18, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795), 2, 1,
                new DateTime(2024, 3, 11, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6795)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 5, 5, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6810), 1,
                new DateTime(2024, 5, 4, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6810), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 7, 9, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6821), 2, 1,
                new DateTime(2024, 7, 8, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6821), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 9, 24, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6833), 3,
                new DateTime(2024, 9, 10, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6833)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 6, 17, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6844), 1, 1,
                new DateTime(2024, 6, 16, 11, 44, 25, 225, DateTimeKind.Unspecified).AddTicks(6844), "OPEN"
            });
    }

    #endregion
}