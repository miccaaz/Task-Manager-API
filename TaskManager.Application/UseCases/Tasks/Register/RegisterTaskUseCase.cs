using TaskManager.Application.UseCases.Tasks.SharedValidations;
using TaskManager.Communication.Entities;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;
using TaskManager.Exceptions.ExceptionsBase;

namespace TaskManager.Application.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseShortTaskJson Excecute(RequestTaskRegisterJson request)
    {
        Validate(request);
        var entity = new TaskEntity
        {
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DueDate = request.DueDate,
            Status = request.Status
        };

        return new ResponseShortTaskJson
        {
            Id = entity.Id,
            Name = entity.Name
        };
    }  

    public void Validate(RequestTaskRegisterJson request)
    {
        var validator = new TaskValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }
    }
}
