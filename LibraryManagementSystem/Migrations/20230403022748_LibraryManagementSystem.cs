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
                name: "books",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    type_book = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_update = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    document_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parent_id = table.Column<int>(type: "int", nullable: false),
                    parent_type = table.Column<int>(type: "int", nullable: false),
                    url = table.Column<int>(type: "int", nullable: false),
                    type_url = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.document_id);
                });

            migrationBuilder.CreateTable(
                name: "evaluations",
                columns: table => new
                {
                    evaluation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    borrowing_id = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comment_rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time_rate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluations", x => x.evaluation_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    access_level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_update = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "booksevaluations",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false),
                    evaluation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksevaluations", x => new { x.book_id, x.evaluation_id });
                    table.ForeignKey(
                        name: "FK_booksevaluations_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksevaluations_evaluations_evaluation_id",
                        column: x => x.evaluation_id,
                        principalTable: "evaluations",
                        principalColumn: "evaluation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booksusers",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false),
                    users_id = table.Column<int>(type: "int", nullable: false),
                    usersuser_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksusers", x => new { x.book_id, x.users_id });
                    table.ForeignKey(
                        name: "FK_booksusers_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksusers_users_usersuser_id",
                        column: x => x.usersuser_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "borrowings",
                columns: table => new
                {
                    borrowing_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    borrowings_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_update = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_borrowings", x => x.borrowing_id);
                    table.ForeignKey(
                        name: "FK_borrowings_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_borrowings_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "evaluationusers",
                columns: table => new
                {
                    evaluation_id = table.Column<int>(type: "int", nullable: false),
                    users_id = table.Column<int>(type: "int", nullable: false),
                    usersuser_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluationusers", x => new { x.evaluation_id, x.users_id });
                    table.ForeignKey(
                        name: "FK_evaluationusers_evaluations_evaluation_id",
                        column: x => x.evaluation_id,
                        principalTable: "evaluations",
                        principalColumn: "evaluation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evaluationusers_users_usersuser_id",
                        column: x => x.usersuser_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "evaluationborrowings",
                columns: table => new
                {
                    evaluation_id = table.Column<int>(type: "int", nullable: false),
                    borrowings_id = table.Column<int>(type: "int", nullable: false),
                    borrowingsborrowing_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluationborrowings", x => new { x.evaluation_id, x.borrowings_id });
                    table.ForeignKey(
                        name: "FK_evaluationborrowings_borrowings_borrowingsborrowing_id",
                        column: x => x.borrowingsborrowing_id,
                        principalTable: "borrowings",
                        principalColumn: "borrowing_id");
                    table.ForeignKey(
                        name: "FK_evaluationborrowings_evaluations_evaluation_id",
                        column: x => x.evaluation_id,
                        principalTable: "evaluations",
                        principalColumn: "evaluation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "returnings",
                columns: table => new
                {
                    returning_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    borrowing_id = table.Column<int>(type: "int", nullable: false),
                    returning_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lost_book = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usersuser_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_returnings", x => x.returning_id);
                    table.ForeignKey(
                        name: "FK_returnings_borrowings_borrowing_id",
                        column: x => x.borrowing_id,
                        principalTable: "borrowings",
                        principalColumn: "borrowing_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_returnings_users_usersuser_id",
                        column: x => x.usersuser_id,
                        principalTable: "users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_booksevaluations_evaluation_id",
                table: "booksevaluations",
                column: "evaluation_id");

            migrationBuilder.CreateIndex(
                name: "IX_booksusers_usersuser_id",
                table: "booksusers",
                column: "usersuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_borrowings_book_id",
                table: "borrowings",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_borrowings_user_id",
                table: "borrowings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_evaluationborrowings_borrowingsborrowing_id",
                table: "evaluationborrowings",
                column: "borrowingsborrowing_id");

            migrationBuilder.CreateIndex(
                name: "IX_evaluationusers_usersuser_id",
                table: "evaluationusers",
                column: "usersuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_returnings_borrowing_id",
                table: "returnings",
                column: "borrowing_id");

            migrationBuilder.CreateIndex(
                name: "IX_returnings_usersuser_id",
                table: "returnings",
                column: "usersuser_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booksevaluations");

            migrationBuilder.DropTable(
                name: "booksusers");

            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.DropTable(
                name: "evaluationborrowings");

            migrationBuilder.DropTable(
                name: "evaluationusers");

            migrationBuilder.DropTable(
                name: "returnings");

            migrationBuilder.DropTable(
                name: "evaluations");

            migrationBuilder.DropTable(
                name: "borrowings");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
