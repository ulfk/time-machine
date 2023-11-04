using Microsoft.EntityFrameworkCore;
using TimeMachine.Persistence.Entities;

namespace TimeMachine.Persistence;

public class TimeMachineContext : DbContext, ITimeMachineContext
{
    public DbSet<TimeLog> TimeLogs { get; set; }

    public DbSet<Project> Projects { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<LogText> LogTexts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConfigFactory.GetConnectionString());
}
