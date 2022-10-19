using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop_TaskBoardApp.Data.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.Task.MaxTitle)]
        public string Title { get; set; }

        [Required]
        [MaxLength(Constants.Task.MaxDescription)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public int BoadrId { get; set; }
        public Board Board { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public User Owner { get; set; }
    }
}
