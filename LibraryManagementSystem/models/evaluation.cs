using  LibraryManagementSystem.models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class evaluation
    {
        [Key]
        public int evaluation_id { get; set; }
        [ForeignKey("user_id")]
        public int user_id { get; set; }
        [ForeignKey("book_id")]
        public int book_id { get; set; }
        [ForeignKey("borrowing_id")]
        public int borrowing_id { get; set; }
        public string? rate { get; set; }
        public string? comment_rate { get; set; }
        public string? time_rate { get; set; }
        public IList<booksevaluation>? booksevaluations { get; set; }
        public IList<evaluationusers>? evaluationusers { get; set; }
    }
}
