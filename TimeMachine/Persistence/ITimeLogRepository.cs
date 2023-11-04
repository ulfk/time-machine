using TimeMachine.Logic.Models;

namespace TimeMachine.Persistence;

public interface ITimeLogRepository
{
    Guid Store(TimeLogView timeLogView);
}
