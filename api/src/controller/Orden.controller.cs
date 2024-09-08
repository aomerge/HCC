using Microsoft.AspNetCore.Mvc;

namespace api.src.controller;

[ApiController]
[Route("api/[controller]")]
public class OrdenController : ControllerBase
{
    public OrdenController()
    {
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Ordenes");
    }
}