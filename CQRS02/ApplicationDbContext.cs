using CQRS02.Entity;
using Microsoft.EntityFrameworkCore;

namespace CQRS02
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}