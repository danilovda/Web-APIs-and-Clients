using DotnetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetAPI.Data;

public class AppDbContext : DbContext
{    
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
    {
        
    }

    public DbSet<Employee> Employees => Set<Employee>();
}