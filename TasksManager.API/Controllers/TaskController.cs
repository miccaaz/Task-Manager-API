using Microsoft.AspNetCore.Mvc;
using TaskManager.Communication.Requests;

namespace TaskManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] RequestTaskRegisterJson request)
    {
        return Created();
    }
}
