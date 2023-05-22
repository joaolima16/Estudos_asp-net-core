using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using login_registro_asp.Models;
using Microsoft.EntityFrameworkCore;
namespace login_registro_asp.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) {}
        public DbSet<UserModel> user { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("Users");
        }
    }
        
}