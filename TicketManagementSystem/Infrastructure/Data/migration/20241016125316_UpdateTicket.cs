#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.migration;

/// <inheritdoc />
public partial class UpdateTicket : Migration
{
    #region Protected methods declaration

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            "ClosedBy",
            "Ticket");

        migrationBuilder.DropColumn(
            "ClosedDate",
            "Ticket");

        migrationBuilder.DropColumn(
            "LastUpdateDate",
            "Ticket");

        migrationBuilder.UpdateData(
            "AspNetUsers",
            "Id",
            "c5e57a7f-39e8-4007-940e-4468dfbb04f3",
            new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            new object[]
            {
                "dfdd891e-5156-490f-ac35-3f10e4dd0c97",
                "AQAAAAIAAYagAAAAEFhfOjTwd/W/1r7pRXIbAOBfMH1mE749ARfDOZ2po3RYm3imEKH77C640WE5q7YoHA==",
                "3f25095d-980c-4c7a-8a70-ad1a531f134c"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            1,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "PriorityId", "Status" },
            new object[] { 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[] { "CategoryId", "ExpectedDate", "Status" },
            new object[] { 2, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "CategoryId", "ExpectedDate", "Status" },
            new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
            new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "CategoryId", "Status" },
            new object[] { 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "PriorityId", "ProductId" },
            new object[] { 2, 3, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "CategoryId", "ExpectedDate", "PriorityId" },
            new object[] { 2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ProductId", "Status" },
            new object[] { 2, 1, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ExpectedDate", "Status" },
            new object[] { 2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
            new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "PriorityId", "ProductId", "Status" },
            new object[] { 1, 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
            new object[] { 3, 1, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
            new object[] { 1, 2, 1, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            "Status",
            "CLOSED");

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ExpectedDate", "PriorityId" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "ExpectedDate", "PriorityId" },
            new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
            new object[] { 1, 2, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "ExpectedDate", "PriorityId", "Status" },
            new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "CategoryId", "ExpectedDate", "Status" },
            new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            "CategoryId",
            2);

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "CategoryId", "ExpectedDate", "ProductId" },
            new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "PriorityId", "ProductId", "Status" },
            new object[] { 2, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            "Status",
            "OPEN");

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "PriorityId", "Status" },
            new object[] { 1, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "CategoryId", "ExpectedDate", "ProductId" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            "ExpectedDate",
            new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
            new object[] { 3, 2, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "CategoryId", "ProductId", "Status" },
            new object[] { 2, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "CategoryId", "PriorityId", "ProductId" },
            new object[] { 1, 1, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ExpectedDate", "PriorityId" },
            new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "CategoryId", "PriorityId", "ProductId", "Status" },
            new object[] { 2, 3, 2, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "ExpectedDate", "PriorityId", "ProductId", "Status" },
            new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "CategoryId", "PriorityId", "Status" },
            new object[] { 1, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ExpectedDate", "ProductId", "Status" },
            new object[] { 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "Status" },
            new object[] { 3, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ExpectedDate" },
            new object[] { 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            "PriorityId",
            2);

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[] { "CategoryId", "ExpectedDate", "PriorityId", "ProductId" },
            new object[] { 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });
    }

    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            "ClosedBy",
            "Ticket",
            "TEXT",
            nullable: true);

        migrationBuilder.AddColumn<DateTime>(
            "ClosedDate",
            "Ticket",
            "TEXT",
            nullable: true);

        migrationBuilder.AddColumn<DateTime>(
            "LastUpdateDate",
            "Ticket",
            "TEXT",
            nullable: true);

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
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
            {
                2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            2,
            new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[] { null, null, null, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            3,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId"
            },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            4,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            5,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[]
                { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            6,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
            new object[]
                { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            7,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            8,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
            new object[] { 2, null, null, null, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            9,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId"
            },
            new object[]
                { 2, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            10,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[]
                { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            11,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            12,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            13,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId" },
            new object[] { 1, null, null, null, 2, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            14,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
            new object[] { null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            15,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
            new object[] { 1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            16,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "ProductId", "Status" },
            new object[] { 1, null, null, null, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            17,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId"
            },
            new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            18,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
            {
                1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3, "CLOSED"
            });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            19,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
            new object[]
                { 3, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            20,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId" },
            new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            21,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            22,
            new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { null, null, null, 2, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            23,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { 1, null, null, null, 2, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            24,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            25,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[]
                { null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            26,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { 3, null, null, null, 3, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            27,
            new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
            new object[] { null, null, null, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            28,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
            new object[] { 2, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            29,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            30,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
            new object[] { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            31,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { 2, null, null, null, 3, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            32,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId"
            },
            new object[]
                { 3, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            33,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[]
                { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            34,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            35,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 3, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            36,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            37,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "Status" },
            new object[]
                { 3, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            38,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate" },
            new object[] { 3, null, null, null });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            39,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId" },
            new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            40,
            new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { null, null, null, 1, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            41,
            new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
            new object[] { null, null, null, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            42,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[] { 3, null, null, null, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            43,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId" },
            new object[] { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            44,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate" },
            new object[] { null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            45,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { 2, null, null, null, 3, 1, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            46,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "ProductId", "Status" },
            new object[] { 1, null, null, null, 1, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            47,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId" },
            new object[] { 2, null, null, null, 2, 3 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            48,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            49,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[]
                { null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            50,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            51,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId" },
            new object[] { 1, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            52,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[] { 3, null, null, null, 1, 1, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            53,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId",
                "Status"
            },
            new object[]
                { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, "OPEN" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            54,
            new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "Status" },
            new object[]
                { null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            55,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId", "Status" },
            new object[] { 2, null, null, null, 2, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            56,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "ProductId", "Status" },
            new object[]
                { 1, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "CLOSED" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            57,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "LastUpdateDate", "Status" },
            new object[] { 1, null, null, null, "NEW" });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            58,
            new[] { "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate" },
            new object[] { 2, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            59,
            new[] { "ClosedBy", "ClosedDate", "LastUpdateDate", "PriorityId" },
            new object[] { null, null, null, 1 });

        migrationBuilder.UpdateData(
            "Ticket",
            "Id",
            60,
            new[]
            {
                "CategoryId", "ClosedBy", "ClosedDate", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId"
            },
            new object[] { 2, null, null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 3 });
    }

    #endregion
}