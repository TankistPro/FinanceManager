using FinanceManager.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace FinanceManager.Infrastructure.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<OperationHistory> OperationHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FinanceManager;Trusted_Connection=True;Integrated Security=True;");
        }
    }
}
