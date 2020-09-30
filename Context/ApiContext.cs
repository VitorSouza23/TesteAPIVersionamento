using Microsoft.EntityFrameworkCore;
using TesteVersionamentoAPI.Models;

namespace TesteVersionamentoAPI.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}