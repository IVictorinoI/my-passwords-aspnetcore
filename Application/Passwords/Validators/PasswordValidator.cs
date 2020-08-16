using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Data;
using Domain.Models.Passwords;

namespace Application.Passwords.Validators
{
    public class PasswordValidator : IPasswordValidator
    {
        private readonly DataContext _context;
        public PasswordValidator(DataContext context)
        {
            _context = context;
        }

        public void Validate(Password password)
        {
            ValidateDuplicity(password);
        }

        private void ValidateDuplicity(Password password)
        {
            var other = _context.Passwords.FirstOrDefault(p => p.Login == password.Login && 
                                                               p.PasswordKey == password.PasswordKey && 
                                                               p.UserId == password.UserId &&
                                                               p.Id != password.Id);

            if (other != null)
                throw new Exception(string.Format("Já existe outra Senha com estes dados {0}.", other));
        }
    }
}
