namespace TimeMachine.Logic.Models
{
    public class TimeLogView
    {
        public Guid? Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string LogText { get; set; } = string.Empty;

        public string LogDescription { get; set; } = string.Empty;

        public Guid ProjectId { get; set; }
    }
}
