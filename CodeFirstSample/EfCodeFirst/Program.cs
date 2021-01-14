using DataAccess;
using Entities;
using System;
using System.Linq;

namespace EfCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var dbContext = new TodoContext())
            {
                var count = dbContext.TodoItems.Count();
                var item = new TodoItem { Name = $"test{++count}" };
                dbContext.Add(item);
                dbContext.SaveChanges();
            }
        }
    }
}
