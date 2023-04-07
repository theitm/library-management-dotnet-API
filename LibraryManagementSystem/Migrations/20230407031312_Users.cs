using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
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
                    date_udate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
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
                    table.PrimaryKey("PK_Documents", x => x.document_id);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
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
                    table.PrimaryKey("PK_Evaluations", x => x.evaluation_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
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
                    access_level = table.Column<int>(type: "int", nullable: true),
                    date_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_udate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "BooksEvaluations",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false),
                    evaluation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksEvaluations", x => new { x.book_id, x.evaluation_id });
                    table.ForeignKey(
                        name: "FK_BooksEvaluations_Books_book_id",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksEvaluations_Evaluations_evaluation_id",
                        column: x => x.evaluation_id,
                        principalTable: "Evaluations",
                        principalColumn: "evaluation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksUsers",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false),
                    users_id = table.Column<int>(type: "int", nullable: false),
                    Usersuser_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksUsers", x => new { x.book_id, x.users_id });
                    table.ForeignKey(
                        name: "FK_BooksUsers_Books_book_id",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksUsers_Users_Usersuser_id",
                        column: x => x.Usersuser_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Borrowings",
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
                    date_udate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowings", x => x.borrowing_id);
                    table.ForeignKey(
                        name: "FK_Borrowings_Books_book_id",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrowings_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationUsers",
                columns: table => new
                {
                    evaluation_id = table.Column<int>(type: "int", nullable: false),
                    users_id = table.Column<int>(type: "int", nullable: false),
                    Usersuser_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationUsers", x => new { x.evaluation_id, x.users_id });
                    table.ForeignKey(
                        name: "FK_EvaluationUsers_Evaluations_evaluation_id",
                        column: x => x.evaluation_id,
                        principalTable: "Evaluations",
                        principalColumn: "evaluation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluationUsers_Users_Usersuser_id",
                        column: x => x.Usersuser_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "EvaluationBorrowings",
                columns: table => new
                {
                    evaluation_id = table.Column<int>(type: "int", nullable: false),
                    borrowings_id = table.Column<int>(type: "int", nullable: false),
                    Borrowingsborrowing_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationBorrowings", x => new { x.evaluation_id, x.borrowings_id });
                    table.ForeignKey(
                        name: "FK_EvaluationBorrowings_Borrowings_Borrowingsborrowing_id",
                        column: x => x.Borrowingsborrowing_id,
                        principalTable: "Borrowings",
                        principalColumn: "borrowing_id");
                    table.ForeignKey(
                        name: "FK_EvaluationBorrowings_Evaluations_evaluation_id",
                        column: x => x.evaluation_id,
                        principalTable: "Evaluations",
                        principalColumn: "evaluation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Returnings",
                columns: table => new
                {
                    returning_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    borrowing_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    returning_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lost_book = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_udate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usersuser_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returnings", x => x.returning_id);
                    table.ForeignKey(
                        name: "FK_Returnings_Borrowings_borrowing_id",
                        column: x => x.borrowing_id,
                        principalTable: "Borrowings",
                        principalColumn: "borrowing_id");
                    table.ForeignKey(
                        name: "FK_Returnings_Users_Usersuser_id",
                        column: x => x.Usersuser_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksEvaluations_evaluation_id",
                table: "BooksEvaluations",
                column: "evaluation_id");

            migrationBuilder.CreateIndex(
                name: "IX_BooksUsers_Usersuser_id",
                table: "BooksUsers",
                column: "Usersuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_book_id",
                table: "Borrowings",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_user_id",
                table: "Borrowings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationBorrowings_Borrowingsborrowing_id",
                table: "EvaluationBorrowings",
                column: "Borrowingsborrowing_id");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationUsers_Usersuser_id",
                table: "EvaluationUsers",
                column: "Usersuser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Returnings_borrowing_id",
                table: "Returnings",
                column: "borrowing_id");

            migrationBuilder.CreateIndex(
                name: "IX_Returnings_Usersuser_id",
                table: "Returnings",
                column: "Usersuser_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksEvaluations");

            migrationBuilder.DropTable(
                name: "BooksUsers");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "EvaluationBorrowings");

            migrationBuilder.DropTable(
                name: "EvaluationUsers");

            migrationBuilder.DropTable(
                name: "Returnings");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Borrowings");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
