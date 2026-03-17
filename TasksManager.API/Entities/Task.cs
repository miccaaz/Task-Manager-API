using TaskManager.Communication.Enums;

namespace TaskManager.API.Entities;

public class Task
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime DueDate { get; set; }
    public Status Status { get; set; }
}
