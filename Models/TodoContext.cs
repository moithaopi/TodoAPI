using System;
using Microsoft.EntityFrameworkCore;
namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        public DbSet<Todo> Todo { get; set; }
    }
}