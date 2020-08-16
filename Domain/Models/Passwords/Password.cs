using System.ComponentModel.DataAnnotations;
using Domain.Models.Users;

namespace Domain.Models.Passwords
{
    public class Password
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Login { get; set; }
        public string PasswordKey { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
