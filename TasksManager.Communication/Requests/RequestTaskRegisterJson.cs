using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestTaskRegisterJson
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime DueDate { get; set; }
    public Status Status { get; set; }
}
