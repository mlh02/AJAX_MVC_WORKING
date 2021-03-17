using Microsoft.EntityFrameworkCore;
using System;
namespace API_AJAX_Mvc.Models

{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
