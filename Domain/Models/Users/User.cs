using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string GetRole()
        {
            return "DefaultRole";
        }
    }
}
