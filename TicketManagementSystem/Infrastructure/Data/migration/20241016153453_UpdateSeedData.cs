#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.migration;

/// <inheritdoc />
public partial class UpdateSeedData : Migration
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
                "0963b03a-0f46-4fd3-ade9-5b5e54338b05",
                "AQAAAAIAAYagAAAAEErr/SQbXz+Y70CJ5QMz9gHvZ6JDIgpCtkN35DYIcClDf8iTbjVannAX55bG62mZVQ==",
                "8b0a2dcb-59e2-4a26-8c41-5895c8c3f57d"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
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
                1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3,
                new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW"
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
                "30cd18c1-3848-428f-a566-1d17ed2526fd",
                "AQAAAAIAAYagAAAAEG2j3PpDRdLrZs7TaWiuvwLX5J7DAZxFE3WeXqGapwhfIjg5zOxCZuju+0LpMDCNEw==",
                "a90b72ce-b55e-43a8-9ee7-aee9819253d9"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
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
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "ExpectedDate", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 3,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ExpectedDate", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600),
                new DateTime(2024, 10, 30, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 1, 1,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 2, 1,
                new DateTime(2024, 10, 16, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), 3, 2,
                new DateTime(2024, 10, 15, 17, 34, 53, 526, DateTimeKind.Local).AddTicks(9600), "OPEN"
            });
    }

    #endregion
}