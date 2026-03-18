using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Register;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseShortTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsMessagesJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskRegisterJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Excecute(request);

        return Created("", response);
    }
}
