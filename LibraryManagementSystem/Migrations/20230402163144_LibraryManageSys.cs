using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class LibraryManageSys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    bookID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_books", x => x.bookID);
                });

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    documentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parentID = table.Column<int>(type: "int", nullable: false),
                    parent_type = table.Column<int>(type: "int", nullable: false),
                    url = table.Column<int>(type: "int", nullable: false),
                    type_url = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.documentID);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    ratingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(type: "int", nullable: false),
                    bookID = table.Column<int>(type: "int", nullable: false),
                    borrowingID = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comment_rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time_rate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.ratingID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "booksratings",
                columns: table => new
                {
                    bookID = table.Column<int>(type: "int", nullable: false),
                    ratingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksratings", x => new { x.bookID, x.ratingID });
                    table.ForeignKey(
                        name: "FK_booksratings_books_bookID",
                        column: x => x.bookID,
                        principalTable: "books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksratings_ratings_ratingID",
                        column: x => x.ratingID,
                        principalTable: "ratings",
                        principalColumn: "ratingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booksusers",
                columns: table => new
                {
                    bookID = table.Column<int>(type: "int", nullable: false),
                    usersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksusers", x => new { x.bookID, x.usersID });
                    table.ForeignKey(
                        name: "FK_booksusers_books_bookID",
                        column: x => x.bookID,
                        principalTable: "books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksusers_users_usersID",
                        column: x => x.usersID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "borrowings",
                columns: table => new
                {
                    borrowingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(type: "int", nullable: false),
                    bookID = table.Column<int>(type: "int", nullable: false),
                    borrowings_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_update = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_borrowings", x => x.borrowingID);
                    table.ForeignKey(
                        name: "FK_borrowings_books_bookID",
                        column: x => x.bookID,
                        principalTable: "books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_borrowings_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ratingusers",
                columns: table => new
                {
                    ratingID = table.Column<int>(type: "int", nullable: false),
                    usersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratingusers", x => new { x.ratingID, x.usersID });
                    table.ForeignKey(
                        name: "FK_ratingusers_ratings_ratingID",
                        column: x => x.ratingID,
                        principalTable: "ratings",
                        principalColumn: "ratingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ratingusers_users_usersID",
                        column: x => x.usersID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ratingborrowings",
                columns: table => new
                {
                    ratingID = table.Column<int>(type: "int", nullable: false),
                    borrowingsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratingborrowings", x => new { x.ratingID, x.borrowingsID });
                    table.ForeignKey(
                        name: "FK_ratingborrowings_borrowings_borrowingsID",
                        column: x => x.borrowingsID,
                        principalTable: "borrowings",
                        principalColumn: "borrowingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ratingborrowings_ratings_ratingID",
                        column: x => x.ratingID,
                        principalTable: "ratings",
                        principalColumn: "ratingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "returnings",
                columns: table => new
                {
                    returningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    borrowingID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    returning_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lost_book = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usersuserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_returnings", x => x.returningID);
                    table.ForeignKey(
                        name: "FK_returnings_borrowings_borrowingID",
                        column: x => x.borrowingID,
                        principalTable: "borrowings",
                        principalColumn: "borrowingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_returnings_users_usersuserID",
                        column: x => x.usersuserID,
                        principalTable: "users",
                        principalColumn: "userID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_booksratings_ratingID",
                table: "booksratings",
                column: "ratingID");

            migrationBuilder.CreateIndex(
                name: "IX_booksusers_usersID",
                table: "booksusers",
                column: "usersID");

            migrationBuilder.CreateIndex(
                name: "IX_borrowings_bookID",
                table: "borrowings",
                column: "bookID");

            migrationBuilder.CreateIndex(
                name: "IX_borrowings_userID",
                table: "borrowings",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_ratingborrowings_borrowingsID",
                table: "ratingborrowings",
                column: "borrowingsID");

            migrationBuilder.CreateIndex(
                name: "IX_ratingusers_usersID",
                table: "ratingusers",
                column: "usersID");

            migrationBuilder.CreateIndex(
                name: "IX_returnings_borrowingID",
                table: "returnings",
                column: "borrowingID");

            migrationBuilder.CreateIndex(
                name: "IX_returnings_usersuserID",
                table: "returnings",
                column: "usersuserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booksratings");

            migrationBuilder.DropTable(
                name: "booksusers");

            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.DropTable(
                name: "ratingborrowings");

            migrationBuilder.DropTable(
                name: "ratingusers");

            migrationBuilder.DropTable(
                name: "returnings");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "borrowings");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
