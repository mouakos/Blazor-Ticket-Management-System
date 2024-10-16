#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.migration;

/// <inheritdoc />
public partial class addOtherEntities : Migration
{
    #region Protected methods declaration

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "Attachments");

        migrationBuilder.DropTable(
            "Discussions");

        migrationBuilder.DropTable(
            "Ticket");

        migrationBuilder.DropTable(
            "Categories");

        migrationBuilder.DropTable(
            "Priorities");

        migrationBuilder.DropTable(
            "Products");
    }

    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "Categories",
            table => new
            {
                Id = table.Column<int>("INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<int>("INTEGER", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Categories", x => x.Id); });

        migrationBuilder.CreateTable(
            "Priorities",
            table => new
            {
                Id = table.Column<int>("INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>("TEXT", nullable: true),
                ExpectedDays = table.Column<int>("INTEGER", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Priorities", x => x.Id); });

        migrationBuilder.CreateTable(
            "Products",
            table => new
            {
                Id = table.Column<int>("INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>("TEXT", nullable: true)
            },
            constraints: table => { table.PrimaryKey("PK_Products", x => x.Id); });

        migrationBuilder.CreateTable(
            "Ticket",
            table => new
            {
                Id = table.Column<int>("INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Summary = table.Column<string>("TEXT", nullable: true),
                Description = table.Column<string>("TEXT", nullable: true),
                RaisedDate = table.Column<DateTime>("TEXT", nullable: false),
                ExpectedDate = table.Column<DateTime>("TEXT", nullable: false),
                AssignedToId = table.Column<string>("TEXT", nullable: true),
                RaisedBy = table.Column<string>("TEXT", nullable: true),
                ProductId = table.Column<int>("INTEGER", nullable: false),
                CategoryId = table.Column<int>("INTEGER", nullable: false),
                PriorityId = table.Column<int>("INTEGER", nullable: false),
                Status = table.Column<string>("TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Ticket", x => x.Id);
                table.ForeignKey(
                    "FK_Ticket_AspNetUsers_AssignedToId",
                    x => x.AssignedToId,
                    "AspNetUsers",
                    "Id");
                table.ForeignKey(
                    "FK_Ticket_AspNetUsers_RaisedBy",
                    x => x.RaisedBy,
                    "AspNetUsers",
                    "Id");
                table.ForeignKey(
                    "FK_Ticket_Categories_CategoryId",
                    x => x.CategoryId,
                    "Categories",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_Ticket_Priorities_PriorityId",
                    x => x.PriorityId,
                    "Priorities",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_Ticket_Products_ProductId",
                    x => x.ProductId,
                    "Products",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "Discussions",
            table => new
            {
                Id = table.Column<int>("INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Message = table.Column<string>("TEXT", nullable: true),
                CreatedDate = table.Column<DateTime>("TEXT", nullable: false),
                TicketId = table.Column<int>("INTEGER", nullable: false),
                UserId = table.Column<string>("TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Discussions", x => x.Id);
                table.ForeignKey(
                    "FK_Discussions_AspNetUsers_UserId",
                    x => x.UserId,
                    "AspNetUsers",
                    "Id");
                table.ForeignKey(
                    "FK_Discussions_Ticket_TicketId",
                    x => x.TicketId,
                    "Ticket",
                    "Id");
            });

        migrationBuilder.CreateTable(
            "Attachments",
            table => new
            {
                Id = table.Column<int>("INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                FileName = table.Column<string>("TEXT", nullable: true),
                ServerFileName = table.Column<string>("TEXT", nullable: true),
                FileSize = table.Column<int>("INTEGER", nullable: false),
                CreatedDate = table.Column<DateTime>("TEXT", nullable: false),
                TicketId = table.Column<int>("INTEGER", nullable: false),
                DiscussionId = table.Column<int>("INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Attachments", x => x.Id);
                table.ForeignKey(
                    "FK_Attachments_Discussions_DiscussionId",
                    x => x.DiscussionId,
                    "Discussions",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_Attachments_Ticket_TicketId",
                    x => x.TicketId,
                    "Ticket",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            "IX_Attachments_DiscussionId",
            "Attachments",
            "DiscussionId");

        migrationBuilder.CreateIndex(
            "IX_Attachments_TicketId",
            "Attachments",
            "TicketId");

        migrationBuilder.CreateIndex(
            "IX_Discussions_TicketId",
            "Discussions",
            "TicketId");

        migrationBuilder.CreateIndex(
            "IX_Discussions_UserId",
            "Discussions",
            "UserId");

        migrationBuilder.CreateIndex(
            "IX_Ticket_AssignedToId",
            "Ticket",
            "AssignedToId");

        migrationBuilder.CreateIndex(
            "IX_Ticket_CategoryId",
            "Ticket",
            "CategoryId");

        migrationBuilder.CreateIndex(
            "IX_Ticket_PriorityId",
            "Ticket",
            "PriorityId");

        migrationBuilder.CreateIndex(
            "IX_Ticket_ProductId",
            "Ticket",
            "ProductId");

        migrationBuilder.CreateIndex(
            "IX_Ticket_RaisedBy",
            "Ticket",
            "RaisedBy");
    }

    #endregion
}