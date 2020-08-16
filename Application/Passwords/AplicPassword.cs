using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.Base;
using Application.Data;
using Application.Passwords.Dto;
using Application.Passwords.Mapper;
using Application.Passwords.Validators;
using Application.Passwords.View;
using Application.Users.Current;
using Domain.Models;
using Domain.Models.Passwords;
using Domain.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Passwords
{
    public class AplicPassword : Aplic, IAplicPassword
    {
        private readonly ICurrentUser _currentUser;
        private readonly IPasswordValidator _passwordValidator;
        public AplicPassword(DataContext context, ICurrentUser currentUser, IPasswordValidator passwordValidator) : base(context)
        {
            _currentUser = currentUser;
            _passwordValidator = passwordValidator;
        }

        public async Task<PasswordView> Insert(PasswordDto dto)
        {
            var reg = new Password();
            new PasswordMapper().Map(reg, dto);

            var user = _currentUser.Get();
            reg.User = user;
            reg.UserId = user.Id;

            _passwordValidator.Validate(reg);

            await Context.Passwords.AddAsync(reg);
            await Context.SaveChangesAsync();

            return PasswordView.New(reg);
        }

        public async Task<PasswordView> Update(int id, PasswordDto dto)
        {
            var reg = await Context.Passwords.FindAsync(id);
            new PasswordMapper().Map(reg, dto);

            _passwordValidator.Validate(reg);

            await Context.SaveChangesAsync();

            return PasswordView.New(reg);
        }

        public async Task<List<PasswordView>> GetByUser()
        {
            var user = _currentUser.Get();

            var passwords = await Context.Passwords
                .Where(p => p.UserId == user.Id)
                .AsNoTracking()
                .ToListAsync();
            
            return passwords.Select(PasswordView.New).ToList();
        }
    }
}
