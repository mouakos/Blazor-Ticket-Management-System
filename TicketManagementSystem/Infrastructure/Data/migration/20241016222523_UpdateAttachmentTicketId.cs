#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.migration;

/// <inheritdoc />
public partial class UpdateAttachmentTicketId : Migration
{
    #region Protected methods declaration

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            "FK_Attachments_Discussions_DiscussionId",
            "Attachments");

        migrationBuilder.DropForeignKey(
            "FK_Attachments_Ticket_TicketId",
            "Attachments");

        migrationBuilder.AlterColumn<int>(
            "TicketId",
            "Attachments",
            "INTEGER",
            nullable: false,
            defaultValue: 0,
            oldClrType: typeof(int),
            oldType: "INTEGER",
            oldNullable: true);

        migrationBuilder.AlterColumn<int>(
            "DiscussionId",
            "Attachments",
            "INTEGER",
            nullable: false,
            defaultValue: 0,
            oldClrType: typeof(int),
            oldType: "INTEGER",
            oldNullable: true);

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
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
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
            13,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
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
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
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
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
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
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 1,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2, 3,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 17, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 30, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 1, 1,
                new DateTime(2024, 10, 16, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998),
                new DateTime(2024, 10, 23, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), 2,
                new DateTime(2024, 10, 15, 23, 29, 33, 428, DateTimeKind.Local).AddTicks(2998), "CLOSED"
            });

        migrationBuilder.AddForeignKey(
            "FK_Attachments_Discussions_DiscussionId",
            "Attachments",
            "DiscussionId",
            "Discussions",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            "FK_Attachments_Ticket_TicketId",
            "Attachments",
            "TicketId",
            "Ticket",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            "FK_Attachments_Discussions_DiscussionId",
            "Attachments");

        migrationBuilder.DropForeignKey(
            "FK_Attachments_Ticket_TicketId",
            "Attachments");

        migrationBuilder.AlterColumn<int>(
            "TicketId",
            "Attachments",
            "INTEGER",
            nullable: true,
            oldClrType: typeof(int),
            oldType: "INTEGER");

        migrationBuilder.AlterColumn<int>(
            "DiscussionId",
            "Attachments",
            "INTEGER",
            nullable: true,
            oldClrType: typeof(int),
            oldType: "INTEGER");

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
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
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
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
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
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
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
            19,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
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
            30,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
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
                3, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                2, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
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
            new[] { "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
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
            42,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 1,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
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
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 2,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate",
                "Status"
            },
            new object[]
            {
                1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3, 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
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
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ClosedDate", "ExpectedDate", "PriorityId", "RaisedDate" },
            new object[]
            {
                3, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate", "Status" },
            new object[]
            {
                null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240),
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "OPEN"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
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
            new[] { "CategoryId", "ExpectedDate", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 31, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 1,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                3, null, null, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "RaisedDate" },
            new object[]
            {
                1, new DateTime(2024, 10, 18, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 2, 3,
                new DateTime(2024, 10, 16, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240)
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "ProductId", "RaisedDate", "Status" },
            new object[]
            {
                1, null, null, new DateTime(2024, 10, 24, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), 3,
                new DateTime(2024, 10, 17, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6240), "NEW"
            });

        migrationBuilder.AddForeignKey(
            "FK_Attachments_Discussions_DiscussionId",
            "Attachments",
            "DiscussionId",
            "Discussions",
            principalColumn: "Id");

        migrationBuilder.AddForeignKey(
            "FK_Attachments_Ticket_TicketId",
            "Attachments",
            "TicketId",
            "Ticket",
            principalColumn: "Id");
    }

    #endregion
}