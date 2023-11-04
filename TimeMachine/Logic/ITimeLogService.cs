using TimeMachine.Logic.Models;

namespace TimeMachine.Logic;

public interface ITimeLogService
{
    Guid Store(TimeLogView timeLog);

    bool Delete(Guid id);

    IEnumerable<TimeLogView> List(Guid userid);

    TimeLogView? Get(Guid id);
}
