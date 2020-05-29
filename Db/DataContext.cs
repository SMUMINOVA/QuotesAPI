using System;
using Microsoft.EntityFrameworkCore;
using QuotesWebAPI.Models;

namespace QuotesWebAPI.Db
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions op) : base(op)
        {
        }
        public DbSet<Quote> Quotes{get;set;}
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Quote>().HasData(
                new Quote{ Id = 1, Text = "The purpose of our lives is to be happy.", Author = "Dalai Lama", InsertDate = DateTime.Now},
                new Quote{ Id = 2, Text = "Life is what happens when you’re busy making other plans.", Author = "John Lennon", InsertDate = DateTime.Now},
                new Quote{ Id = 3, Text = "Get busy living or get busy dying.", Author = "Stephen King", InsertDate = DateTime.Now},
                new Quote{ Id = 4, Text = "You only live once, but if you do it right, once is enough", Author = "Mae West", InsertDate = DateTime.Now},
                new Quote{ Id = 5, Text = "Never let the fear of striking out keep you from playing the game", Author = "Babe Ruth", InsertDate = DateTime.Now}            
            );
        }
    }
}
