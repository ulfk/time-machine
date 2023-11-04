using Microsoft.EntityFrameworkCore;
using TimeMachine.Persistence.Entities;

namespace TimeMachine.Persistence;

public interface ITimeMachineContext
{
    DbSet<TimeLog> TimeLogs { get; set; }

    DbSet<Project> Projects { get; set; }

    DbSet<User> Users { get; set; }
}
