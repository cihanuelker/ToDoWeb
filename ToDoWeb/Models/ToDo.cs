using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoWeb.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [DisplayName ("Created")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        [DisplayName("Status")]
        public bool IsCompleted { get; set; } = false;
    }
}
