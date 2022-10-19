using System.ComponentModel.DataAnnotations;

namespace Workshop_TaskBoardApp.Data.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.Board.MaxName)]
        public string Name { get; set; } = null!;

        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
