using TimeMachine.Persistence;
using TimeMachine.Logic.Models;

namespace TimeMachineTests;

[TestClass]
public class TimeLogRepositoryTests
{
    private ILogger<TimeLogRepository>? _logger;
    private ITimeMachineContext? _context;
    private TimeLogRepository? _timeLogRepository;

    [TestInitialize]
    public void Init()
    {
        _logger = Substitute.For<ILogger<TimeLogRepository>>();
        _context = Substitute.For<ITimeMachineContext>();
        _timeLogRepository = new TimeLogRepository(_logger, _context);
    }

    [TestMethod]
    public void StoreWithoutIdReturnsNewGuid()
    {
        var result = _timeLogRepository!.Store(new TimeLogView());
        Check.That(result).IsNotEqualTo(Guid.Empty);
    }
}