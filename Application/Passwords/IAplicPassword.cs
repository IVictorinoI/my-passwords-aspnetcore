using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.Passwords.Dto;
using Application.Passwords.View;

namespace Application.Passwords
{
    public interface IAplicPassword
    {
        Task<PasswordView> Insert(PasswordDto dto);
        Task<PasswordView> Update(int id, PasswordDto dto);
        Task<List<PasswordView>> GetByUser();
    }
}
