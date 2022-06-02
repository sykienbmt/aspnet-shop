using dotnet.shop.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.shop.Data;

public class ApplicationDbContext:DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Category> Category { get; set; }
}
