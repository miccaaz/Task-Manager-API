using FluentValidation;
using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Tasks.SharedValidations
{
    public class TaskValidator : AbstractValidator<RequestTaskRegisterJson>
    {
        public TaskValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("O nome não pode estar vazio!");
            RuleFor(x => x.Description).MaximumLength(100).WithMessage("A descrição deve ter no máximo 100 caracteres!");
            RuleFor(x => x.Priority).IsInEnum().WithMessage("A prioridade deve ser válida!");
            RuleFor(x => x.DueDate).GreaterThanOrEqualTo(DateTime.UtcNow).WithMessage("A data limite não pode estar no passado!");
            RuleFor(x => x.Status).IsInEnum().WithMessage("O status deve ser válido!");
        }
    }
}
