using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class LibraryManagementSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Document_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Parent_type = table.Column<int>(type: "int", nullable: false),
                    URL = table.Column<int>(type: "int", nullable: false),
                    Type_URL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Document_ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeBook",
                columns: table => new
                {
                    Type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBook", x => x.Type_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Access_level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Book_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_ID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publication_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeBookType_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Book_ID);
                    table.ForeignKey(
                        name: "FK_Book_TypeBook_TypeBookType_ID",
                        column: x => x.TypeBookType_ID,
                        principalTable: "TypeBook",
                        principalColumn: "Type_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrowing",
                columns: table => new
                {
                    Borrowing_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Borrowing_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Due_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Returning_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowing", x => x.Borrowing_ID);
                    table.ForeignKey(
                        name: "FK_Borrowing_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    Evaluation_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Book_ID = table.Column<int>(type: "int", nullable: false),
                    Borrowing_ID = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time_rate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.Evaluation_ID);
                    table.ForeignKey(
                        name: "FK_Evaluation_Book_Book_ID",
                        column: x => x.Book_ID,
                        principalTable: "Book",
                        principalColumn: "Book_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluation_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowingDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrowing_ID = table.Column<int>(type: "int", nullable: false),
                    Book_ID = table.Column<int>(type: "int", nullable: false),
                    Return_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowingDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BorrowingDetail_Book_Book_ID",
                        column: x => x.Book_ID,
                        principalTable: "Book",
                        principalColumn: "Book_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowingDetail_Borrowing_Borrowing_ID",
                        column: x => x.Borrowing_ID,
                        principalTable: "Borrowing",
                        principalColumn: "Borrowing_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_TypeBookType_ID",
                table: "Book",
                column: "TypeBookType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_User_ID",
                table: "Borrowing",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingDetail_Book_ID",
                table: "BorrowingDetail",
                column: "Book_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingDetail_Borrowing_ID",
                table: "BorrowingDetail",
                column: "Borrowing_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_Book_ID",
                table: "Evaluation",
                column: "Book_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_User_ID",
                table: "Evaluation",
                column: "User_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowingDetail");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Borrowing");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "TypeBook");
        }
    }
}
