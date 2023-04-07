using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using LibraryManagementSystem.models;

public class Books
{
    [Key]
    public int book_id { get; set; }
    public string? title { get; set; }
    public string? author { get; set; }
    public string? publisher { get; set; }
    public string? publication { get; set; }
    public int? quantity { get; set; }
    public string? type_book { get; set; }
    public string? date_created { get; set; }
    public string? date_udate { get; set; }
    public ICollection<Borrowings>? Borrowings { get; set; }
    public IList<BooksEvaluation>? booksevaluation { get; set; }
    public IList<BooksUsers>? BooksUsers { get; set; }
}