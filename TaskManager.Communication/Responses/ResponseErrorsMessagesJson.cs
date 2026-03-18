namespace TaskManager.Communication.Responses;

public class ResponseErrorsMessagesJson
{
    List<string> ErrorsMessages = [];
    public ResponseErrorsMessagesJson(string error)
    {
        ErrorsMessages = [error];
    }

    public ResponseErrorsMessagesJson(List<string> errors)
    {
        ErrorsMessages = errors;
    }
}
