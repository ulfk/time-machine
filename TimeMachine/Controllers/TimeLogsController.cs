using Microsoft.AspNetCore.Mvc;
using TimeMachine.Logic.Models;
using TimeMachine.Logic;

namespace TimeMachine.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeLogsController
{
    private readonly ILogger<TimeLogsController> _logger;
    private readonly ITimeLogService _timeLogService;

    public TimeLogsController(ILogger<TimeLogsController> logger, ITimeLogService timeLogService)
    {
        _logger = logger;
        _timeLogService = timeLogService;
    }

    [HttpGet]
    public IEnumerable<TimeLogView> GetTimeLogs(Guid userId)
    {
        _logger.LogDebug(nameof(GetTimeLogs));
        return _timeLogService.List(userId);
    }
}
