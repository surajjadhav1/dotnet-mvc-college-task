using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicWebApp.Services;

public class MetMumbaiDbContext : DbContext
{
  public DbSet<Course> Courses { get; set; }

  public DbSet<Student> Students { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\College;Database=MetMumbai");
    }


}
