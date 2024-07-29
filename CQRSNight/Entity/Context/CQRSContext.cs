using CQRSNight.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.Entity.Context;

public class CQRSContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-A6C5CRN\\MSSQLSERVER01;Initial Catalog=DbCQRS;Integrated Security=True;Trust Server Certificate=True;");
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
