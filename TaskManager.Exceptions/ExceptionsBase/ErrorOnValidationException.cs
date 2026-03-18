namespace TaskManager.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : TaskManagerException
{
    List<string> Errors = [];
    public ErrorOnValidationException(List<string> errorsMessages) : base(string.Empty)
    {
        Errors = errorsMessages;
    }
}
