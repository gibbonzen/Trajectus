using System.ComponentModel.DataAnnotations;

namespace Trajectus.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }

    }
}