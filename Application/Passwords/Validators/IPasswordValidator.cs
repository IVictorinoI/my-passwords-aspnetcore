using Domain.Models.Passwords;

namespace Application.Passwords.Validators
{
    public interface IPasswordValidator
    {
        void Validate(Password password);
    }
}