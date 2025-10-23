using Microsoft.EntityFrameworkCore;
using Pschool.Models;

namespace Pschool.Data
{
    public class PschoolContext : DbContext
    {
        public PschoolContext(DbContextOptions<PschoolContext> options) : base(options)
        {

        }

        DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
    }
}