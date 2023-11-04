using Microsoft.AspNetCore.Mvc;
using TimeMachine.Logic;
using TimeMachine.Logic.Models;

namespace TimeMachine.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeLogController : Controller
{
    private readonly ILogger<TimeLogController> _logger;
    private readonly ITimeLogService _timeLogService;

    public TimeLogController(ILogger<TimeLogController> logger, ITimeLogService timeLogService)
    {
        _logger = logger;
        _timeLogService = timeLogService;
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetTimeLog(Guid id)
    {
        _logger.LogDebug(nameof(StoreTimeLog));
        var result = _timeLogService.Get(id);

        if (result == null) return NotFound($"timelog with id {id} not found");

        return Ok(result);
    }

    [HttpPost]
    public Guid StoreTimeLog(TimeLogView timeLog)
    {
        _logger.LogDebug(nameof(StoreTimeLog));
        return _timeLogService.Store(timeLog);
    }


    [HttpDelete]
    public Guid DeleteTimeLog(Guid id)
    {
        _logger.LogDebug(nameof(DeleteTimeLog));
        throw new NotImplementedException();
    }
}
