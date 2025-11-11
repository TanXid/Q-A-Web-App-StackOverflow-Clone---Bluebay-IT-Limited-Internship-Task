using System.ComponentModel.DataAnnotations;

namespace StackOverflowClone.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public string PostedBy { get; set; }

        public DateTime PostedDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
