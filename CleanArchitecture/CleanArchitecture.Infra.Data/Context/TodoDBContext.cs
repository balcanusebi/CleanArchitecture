using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Context
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions options): base(options) 
        {
        }

        public DbSet<ToDo> Todos { get; set; }
    }
}
