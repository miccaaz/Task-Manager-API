namespace TaskManager.Communication.Responses;

public class ResponseErrorsJson
{
    public List<string> ErrorsMessages { get; set; } = [];
    public ResponseErrorsJson(string error)
    {
        ErrorsMessages = [error];
    }

    public ResponseErrorsJson(List<string> errors)
    {
        ErrorsMessages = errors;
    }
}
