using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflowClone.Models
{
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }

        public string PostedBy { get; set; }

        public DateTime PostedDate { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
