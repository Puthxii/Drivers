using Drivers.Api.Models.Product;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Api.Data;

public class ApiDbContext : IdentityDbContext
{
    public DbSet<Product> Products { get; set; }
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }
    
}
