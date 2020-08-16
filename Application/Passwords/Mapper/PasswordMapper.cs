using System;
using System.Collections.Generic;
using System.Text;
using Application.Passwords.Dto;
using Domain.Models;
using Domain.Models.Passwords;

namespace Application.Passwords.Mapper
{
    public class PasswordMapper
    {
        public void Map(Password reg, PasswordDto dto)
        {
            reg.Description = dto.Description;
            reg.Login = dto.Login;
            reg.PasswordKey = dto.PasswordKey;
        }
    }
}
