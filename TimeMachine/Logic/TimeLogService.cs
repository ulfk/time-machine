using TimeMachine.Logic.Models;
using TimeMachine.Persistence;

namespace TimeMachine.Logic;

public class TimeLogService : ITimeLogService
{
    private readonly ILogger<TimeLogService> _logger;
    private readonly ITimeLogRepository _timeLogRepository;

    public TimeLogService(ILogger<TimeLogService> logger, ITimeLogRepository timeLogRepository)
    {
        _logger = logger;
        _timeLogRepository = timeLogRepository;
    }

    public Guid Store(TimeLogView timeLog)
    {
        _logger.LogDebug(nameof(Store));
        return _timeLogRepository.Store(timeLog);
    }

    public bool Delete(Guid id)
    {
        _logger.LogDebug(nameof(Delete));
        throw new NotImplementedException();
    }

    public IEnumerable<TimeLogView> List(Guid userid)
    {
        _logger.LogDebug(nameof(List));
        throw new NotImplementedException();
    }

    public TimeLogView? Get(Guid id)
    {
        _logger.LogDebug(nameof(Get));
        throw new NotImplementedException();
    }
}
