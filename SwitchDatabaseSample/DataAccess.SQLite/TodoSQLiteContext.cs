using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.SQLite
{
    public class TodoSQLiteContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=SwitchDB.db");
    }
}
