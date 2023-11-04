using TimeMachine.Logic.Models;
using TimeMachine.Persistence.Entities;

namespace TimeMachine.Persistence;

public class TimeLogRepository : ITimeLogRepository
{
    private readonly ILogger<TimeLogRepository> _logger;
    private readonly ITimeMachineContext _context;

    public TimeLogRepository(ILogger<TimeLogRepository> logger, ITimeMachineContext context)
    {
        _logger = logger;
        _context = context;
    }

    public Guid Store(TimeLogView timeLogView)
    {
        _logger.LogDebug(nameof(Store));
        if (timeLogView == null) throw new ArgumentNullException(nameof(timeLogView));
        var entity = ViewToEntity(timeLogView);
        if (timeLogView.Id.HasValue)
        {
            _context.TimeLogs.Update(entity);
        }
        else
        {
            _context.TimeLogs.Add(entity);
        }

        return entity.Id;
    }

    private static TimeLog ViewToEntity(TimeLogView timeLogView)
    {
        return new TimeLog
        {
            Id = timeLogView.Id.HasValue ? timeLogView.Id.Value : Guid.NewGuid(),
            UserId = timeLogView.UserId,
            Start = timeLogView.Start,
            End = timeLogView.End,
            LogText = timeLogView.LogText,
            LogDescription = timeLogView.LogDescription,
            ProjectId = timeLogView.ProjectId
        };
    }
}
