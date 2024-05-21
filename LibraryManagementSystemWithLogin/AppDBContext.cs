using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalExamDhrutiben
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> users { get; set; }

        // entity mapping with Book Class
        public DbSet<Book> books { get; set; }

        // entity mapping with member class
        public DbSet<Member> members { get; set; }

        // entity mapping with book issue class
        public DbSet<BookIssue> bookIssue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=dhrutiben;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { userID = 1, password = "admin", role = "Admin", userName = "admin" });

            modelBuilder.Entity<Book>().HasData(new Book { bookID = 1, title = "Wings of Fire", author = "Dr. APJ Abdul Kalam", isAvailable = true },
            new Book { bookID = 2, title = "The art of happiness", author = "Dalai Lama", isAvailable = true },
            new Book { bookID = 3, title = "The art of letting go", author = "Damon Zahariades", isAvailable = true });
        }
    }
}
