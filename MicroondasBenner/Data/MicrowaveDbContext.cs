using MicroondasBenner.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroondasBenner.Data;

public class MicrowaveDbContext: DbContext
{
    public DbSet<CookModels> CookModes { get; set; }
    public MicrowaveDbContext(DbContextOptions<MicrowaveDbContext> options)
    : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
