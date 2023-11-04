namespace TimeMachine.Persistence.Entities;

public class LogText
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid ProjectId { get; set; }

    public string Text { get; set; } = string.Empty;
}
