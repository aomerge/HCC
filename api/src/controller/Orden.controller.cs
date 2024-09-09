using Microsoft.AspNetCore.Mvc;

namespace api.src.controller;

[ApiController]
[Route("api/[controller]")]
public class ordenController : ControllerBase
{
    public ordenController()
    {
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Ordenes");
    }
}