using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.SQLServer
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SwitchDB;Integrated Security=True;");
    }
}
