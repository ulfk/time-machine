using TimeMachine.Logic;
using TimeMachine.Logic.Models;
using TimeMachine.Persistence;

namespace TimeMachineTests.Logic;

[TestClass]
public class TimeLogServiceTests
{
    private ILogger<TimeLogService>? _logger;
    private TimeLogService? _timeLogService;
    private ITimeLogRepository? _timeLogRepository;

    [TestInitialize]
    public void Init()
    {
        _logger = Substitute.For<ILogger<TimeLogService>>();
        _timeLogRepository = Substitute.For<ITimeLogRepository>();
        _timeLogService = new TimeLogService(_logger, _timeLogRepository);
    }

    [TestMethod]
    public void StoreWithoutIdReturnsNewId()
    {
        _timeLogRepository!.Store(Arg.Any<TimeLogView>()).Returns(Guid.NewGuid());
        var result = _timeLogService!.Store(new TimeLogView());
        Check.That(result).IsNotEqualTo(Guid.Empty);
    }

    [TestMethod]
    public void StoreWithIdReturnsGivenId()
    {
        var id = Guid.NewGuid();
        var timeLog = new TimeLogView { Id = id };
        _timeLogRepository!.Store(Arg.Is(timeLog)).Returns(id);
        var result = _timeLogService!.Store(timeLog);
        Check.That(result).Equals(id);
    }
}