namespace TimeMachine.Persistence.Entities;

public class Project
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool Active { get; set; }
}
