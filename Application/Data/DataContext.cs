using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Models.Passwords;
using Domain.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Application.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
