using AdminNotificator.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AdminNotificator.Core;

public class AdminNotificatorDbContext : DbContext
{
    public AdminNotificatorDbContext(DbContextOptions<AdminNotificatorDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<EmailType> EmailTypes { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<EmailType>()
            .HasKey(x => x.Id);

        builder.Entity<UserProfile>()
            .HasKey(x => x.Id);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { 
        optionsBuilder.UseInMemoryDatabase("AdminDb"); 
    } 
}