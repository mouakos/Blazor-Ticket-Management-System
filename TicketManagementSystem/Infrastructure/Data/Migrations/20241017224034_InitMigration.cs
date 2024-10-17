using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AccountConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Avatar = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExpectedDays = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssignedToId = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClosedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ExpectedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PriorityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaisedBy = table.Column<string>(type: "TEXT", nullable: true),
                    RaisedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Summary = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_AspNetUsers_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ticket_AspNetUsers_RaisedBy",
                        column: x => x.RaisedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ticket_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discussions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Discussions_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiscussionId = table.Column<int>(type: "INTEGER", nullable: true),
                    FileName = table.Column<string>(type: "TEXT", nullable: true),
                    FileSize = table.Column<long>(type: "INTEGER", nullable: false),
                    ServerFileName = table.Column<string>(type: "TEXT", nullable: true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_Discussions_DiscussionId",
                        column: x => x.DiscussionId,
                        principalTable: "Discussions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attachments_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48395b9b-a292-4a48-80df-ebc6a057f6c0", null, "Admin", "ADMIN" },
                    { "6367a40d-3014-43bc-a704-135f41abae2d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountConfirmed", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5e57a7f-39e8-4007-940e-4468dfbb04f3", 0, false, null, "68426e23-e1a9-4503-98c0-8c4da0318fd3", "test@gmail.com", true, false, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAIAAYagAAAAENVX4RctH0ZiTK7BL4MAxK5830/KnzjxJaHnXJB1jMSWe+G4n02FifkqoT85YgSLsA==", null, false, "3ebc74dd-b69e-4eff-965c-757f4c5fbef6", false, "test@gmail.com" });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48395b9b-a292-4a48-80df-ebc6a057f6c0", "c5e57a7f-39e8-4007-940e-4468dfbb04f3" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "AssignedToId", "CategoryId", "ClosedBy", "ClosedDate", "Description", "ExpectedDate", "LastUpdateDate", "PriorityId", "ProductId", "RaisedBy", "RaisedDate", "Status", "Summary" },
                values: new object[,]
                {
                    { 1, null, 2, null, null, "Description for ticket 2", new DateTime(2024, 2, 17, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(5147), null, 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 3, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(5147), "OPEN", "Sample ticket 2" },
                    { 2, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 12, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7092), "Description for ticket 3", new DateTime(2024, 10, 12, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7092), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7092), "CLOSED", "Sample ticket 3" },
                    { 3, null, 3, null, null, "Description for ticket 4", new DateTime(2024, 7, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7138), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7138), "OPEN", "Sample ticket 4" },
                    { 4, null, 1, null, null, "Description for ticket 5", new DateTime(2024, 8, 27, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7154), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 26, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7154), "OPEN", "Sample ticket 5" },
                    { 5, null, 2, null, null, "Description for ticket 6", new DateTime(2024, 4, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7167), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 24, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7167), "NEW", "Sample ticket 6" },
                    { 6, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7180), "Description for ticket 7", new DateTime(2024, 10, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7180), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 17, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7180), "CLOSED", "Sample ticket 7" },
                    { 7, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 10, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7224), "Description for ticket 8", new DateTime(2024, 8, 10, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7224), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 9, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7224), "CLOSED", "Sample ticket 8" },
                    { 8, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 14, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7238), "Description for ticket 9", new DateTime(2024, 10, 14, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7238), null, 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 30, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7238), "CLOSED", "Sample ticket 9" },
                    { 9, null, 2, null, null, "Description for ticket 10", new DateTime(2024, 1, 26, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7252), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 12, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7252), "OPEN", "Sample ticket 10" },
                    { 10, null, 2, null, null, "Description for ticket 11", new DateTime(2024, 1, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7265), null, 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7265), "OPEN", "Sample ticket 11" },
                    { 11, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7277), "Description for ticket 12", new DateTime(2024, 6, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7277), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 9, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7277), "CLOSED", "Sample ticket 12" },
                    { 12, null, 1, null, null, "Description for ticket 13", new DateTime(2024, 1, 22, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7290), null, 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 8, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7290), "NEW", "Sample ticket 13" },
                    { 13, null, 2, null, null, "Description for ticket 14", new DateTime(2024, 6, 13, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7303), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 6, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7303), "NEW", "Sample ticket 14" },
                    { 14, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 5, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7314), "Description for ticket 15", new DateTime(2024, 6, 5, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7314), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 29, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7314), "CLOSED", "Sample ticket 15" },
                    { 15, null, 2, null, null, "Description for ticket 16", new DateTime(2024, 5, 2, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7327), null, 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7327), "NEW", "Sample ticket 16" },
                    { 16, null, 3, null, null, "Description for ticket 17", new DateTime(2024, 5, 15, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7370), null, 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 14, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7370), "OPEN", "Sample ticket 17" },
                    { 17, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7383), "Description for ticket 18", new DateTime(2024, 4, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7383), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7383), "CLOSED", "Sample ticket 18" },
                    { 18, null, 3, null, null, "Description for ticket 19", new DateTime(2024, 4, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7396), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 31, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7396), "NEW", "Sample ticket 19" },
                    { 19, null, 2, null, null, "Description for ticket 20", new DateTime(2024, 5, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7408), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 24, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7408), "OPEN", "Sample ticket 20" },
                    { 20, null, 1, null, null, "Description for ticket 21", new DateTime(2024, 5, 28, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7421), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 27, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7421), "NEW", "Sample ticket 21" },
                    { 21, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7433), "Description for ticket 22", new DateTime(2024, 3, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7433), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 16, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7433), "CLOSED", "Sample ticket 22" },
                    { 22, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7446), "Description for ticket 23", new DateTime(2024, 7, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7446), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 17, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7446), "CLOSED", "Sample ticket 23" },
                    { 23, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7459), "Description for ticket 24", new DateTime(2024, 1, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7459), null, 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 9, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7459), "CLOSED", "Sample ticket 24" },
                    { 24, null, 3, null, null, "Description for ticket 25", new DateTime(2024, 9, 22, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7472), null, 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 15, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7472), "NEW", "Sample ticket 25" },
                    { 25, null, 2, null, null, "Description for ticket 26", new DateTime(2024, 5, 9, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7513), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 8, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7513), "NEW", "Sample ticket 26" },
                    { 26, null, 3, null, null, "Description for ticket 27", new DateTime(2024, 5, 24, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7530), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 17, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7530), "NEW", "Sample ticket 27" },
                    { 27, null, 3, null, null, "Description for ticket 28", new DateTime(2024, 2, 28, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7542), null, 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 14, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7542), "OPEN", "Sample ticket 28" },
                    { 28, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 7, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7554), "Description for ticket 29", new DateTime(2024, 9, 7, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7554), null, 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 6, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7554), "CLOSED", "Sample ticket 29" },
                    { 29, null, 2, null, null, "Description for ticket 30", new DateTime(2024, 5, 16, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7567), null, 1, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 2, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7567), "OPEN", "Sample ticket 30" },
                    { 30, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 5, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7580), "Description for ticket 31", new DateTime(2024, 3, 5, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7580), null, 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 20, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7580), "CLOSED", "Sample ticket 31" },
                    { 31, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7593), "Description for ticket 32", new DateTime(2024, 2, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7593), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 10, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7593), "CLOSED", "Sample ticket 32" },
                    { 32, null, 1, null, null, "Description for ticket 33", new DateTime(2024, 2, 3, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7605), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 27, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7605), "NEW", "Sample ticket 33" },
                    { 33, null, 1, null, null, "Description for ticket 34", new DateTime(2024, 6, 7, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7635), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 6, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7635), "NEW", "Sample ticket 34" },
                    { 34, null, 2, null, null, "Description for ticket 35", new DateTime(2024, 4, 30, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7649), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7649), "OPEN", "Sample ticket 35" },
                    { 35, null, 2, null, null, "Description for ticket 36", new DateTime(2024, 4, 13, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7661), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 30, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7661), "OPEN", "Sample ticket 36" },
                    { 36, null, 2, null, null, "Description for ticket 37", new DateTime(2024, 8, 12, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7673), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7673), "NEW", "Sample ticket 37" },
                    { 37, null, 1, null, null, "Description for ticket 38", new DateTime(2024, 7, 2, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7686), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7686), "NEW", "Sample ticket 38" },
                    { 38, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 7, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7698), "Description for ticket 39", new DateTime(2024, 4, 7, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7698), null, 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 31, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7698), "CLOSED", "Sample ticket 39" },
                    { 39, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7711), "Description for ticket 40", new DateTime(2024, 2, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7711), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 28, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7711), "CLOSED", "Sample ticket 40" },
                    { 40, null, 3, null, null, "Description for ticket 41", new DateTime(2024, 9, 9, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7723), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 8, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7723), "NEW", "Sample ticket 41" },
                    { 41, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 2, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7735), "Description for ticket 42", new DateTime(2024, 4, 2, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7735), null, 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 26, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7735), "CLOSED", "Sample ticket 42" },
                    { 42, null, 1, null, null, "Description for ticket 43", new DateTime(2024, 5, 8, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7788), null, 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 7, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7788), "OPEN", "Sample ticket 43" },
                    { 43, null, 2, null, null, "Description for ticket 44", new DateTime(2024, 5, 17, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7803), null, 1, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 16, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7803), "OPEN", "Sample ticket 44" },
                    { 44, null, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 20, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7815), "Description for ticket 45", new DateTime(2024, 9, 20, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7815), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 6, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7815), "CLOSED", "Sample ticket 45" },
                    { 45, null, 2, null, null, "Description for ticket 46", new DateTime(2024, 5, 27, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7828), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 20, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7828), "NEW", "Sample ticket 46" },
                    { 46, null, 1, null, null, "Description for ticket 47", new DateTime(2024, 8, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7840), null, 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7840), "NEW", "Sample ticket 47" },
                    { 47, null, 1, null, null, "Description for ticket 48", new DateTime(2024, 10, 17, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7852), null, 2, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 10, 16, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7852), "NEW", "Sample ticket 48" },
                    { 48, null, 3, null, null, "Description for ticket 49", new DateTime(2024, 6, 26, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7864), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 12, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7864), "NEW", "Sample ticket 49" },
                    { 49, null, 3, null, null, "Description for ticket 50", new DateTime(2024, 5, 12, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7876), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 11, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7876), "OPEN", "Sample ticket 50" },
                    { 50, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7888), "Description for ticket 51", new DateTime(2024, 4, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7888), null, 3, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 4, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7888), "CLOSED", "Sample ticket 51" },
                    { 51, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 30, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7939), "Description for ticket 52", new DateTime(2024, 3, 30, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7939), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 3, 29, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7939), "CLOSED", "Sample ticket 52" },
                    { 52, null, 3, null, null, "Description for ticket 53", new DateTime(2024, 2, 25, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7953), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 2, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7953), "OPEN", "Sample ticket 53" },
                    { 53, null, 1, null, null, "Description for ticket 54", new DateTime(2024, 6, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7966), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 31, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7966), "OPEN", "Sample ticket 54" },
                    { 54, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7978), "Description for ticket 55", new DateTime(2024, 4, 23, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7978), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 4, 16, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7978), "CLOSED", "Sample ticket 55" },
                    { 55, null, 2, null, null, "Description for ticket 56", new DateTime(2024, 7, 21, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7991), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 7, 14, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(7991), "NEW", "Sample ticket 56" },
                    { 56, null, 2, null, null, "Description for ticket 57", new DateTime(2024, 2, 4, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8003), null, 2, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 1, 21, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8003), "NEW", "Sample ticket 57" },
                    { 57, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 5, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8016), "Description for ticket 58", new DateTime(2024, 6, 5, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8016), null, 3, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 5, 29, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8016), "CLOSED", "Sample ticket 58" },
                    { 58, null, 2, null, null, "Description for ticket 59", new DateTime(2024, 7, 1, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8030), null, 2, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 6, 30, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8030), "NEW", "Sample ticket 59" },
                    { 59, null, 3, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 19, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8042), "Description for ticket 60", new DateTime(2024, 8, 19, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8042), null, 3, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 8, 18, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8042), "CLOSED", "Sample ticket 60" },
                    { 60, null, 1, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 24, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8083), "Description for ticket 61", new DateTime(2024, 9, 24, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8083), null, 1, 2, "c5e57a7f-39e8-4007-940e-4468dfbb04f3", new DateTime(2024, 9, 10, 0, 40, 34, 147, DateTimeKind.Unspecified).AddTicks(8083), "CLOSED", "Sample ticket 61" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_DiscussionId",
                table: "Attachments",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_TicketId",
                table: "Attachments",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_TicketId",
                table: "Discussions",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_UserId",
                table: "Discussions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_AssignedToId",
                table: "Ticket",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CategoryId",
                table: "Ticket",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PriorityId",
                table: "Ticket",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ProductId",
                table: "Ticket",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_RaisedBy",
                table: "Ticket",
                column: "RaisedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
