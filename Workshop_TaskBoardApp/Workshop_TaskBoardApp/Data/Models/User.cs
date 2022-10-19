using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Workshop_TaskBoardApp.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(Constants.User.MaxFirstName)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(Constants.User.MaxLastName)]
        public string LastName { get; set; } = null!;
    }
}
