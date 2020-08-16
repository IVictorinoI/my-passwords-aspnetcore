using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Models.Passwords;

namespace Application.Passwords.View
{
    public class PasswordView
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static PasswordView New(Password p)
        {
            return new PasswordView()
            {
                Id = p.Id,
                Description = p.Description
            };
        }
    }
}
