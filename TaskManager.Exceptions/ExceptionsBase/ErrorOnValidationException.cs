namespace TaskManager.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : TaskManagerException
{
    public List<string> Errors { get; set; } = [];
    public ErrorOnValidationException(List<string> errorsMessages) : base(string.Empty)
    {
        Errors = errorsMessages;
    }
}
