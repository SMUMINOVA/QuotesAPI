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
    }
}
