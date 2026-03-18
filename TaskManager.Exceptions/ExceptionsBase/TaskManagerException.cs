namespace TaskManager.Exceptions.ExceptionsBase;

public class TaskManagerException : SystemException
{
    public TaskManagerException(string errorMessage) : base(errorMessage)
    {
    }
}
