using Microsoft.AspNetCore.Mvc;
using api.src.services;
using api.src.abstraction;
using api.src.model;
using api.src.config;
namespace api.src.controller;

[ApiController]
[Route("api/[controller]")]
public class ordenController : ControllerBase
{
    private readonly IOrden _ordenService;

    public ordenController(IOrden ordenService)
    {
        _ordenService = ordenService;
    }    

    [HttpGet]    
    public IActionResult Get()
    {
        _ordenService.Get();
        return Ok("Ordenes");
    }

    [HttpGet("obtenerOrdenes")]
    public ActionResult<List<tbHccOrdenes>> GetOrdenes()
    {
        var ordenes = _ordenService.GetAll();
        var respuesta = new resultadoExitoso<tbHccOrdenes>
            {
                estatus = 200,
                Mensaje = "Peticion exitosa",
                Fecha = DateTime.Now,
                Datos = ordenes,
                codigo = 1
            };        

        return Ok(respuesta);
    }

    [HttpPost("agregarOrden")]
    public IActionResult AddOrden([FromBody] tbHccOrdenes orden)
    {
        if(orden == null)
        {
            return BadRequest("Orden no puede ser nulo");
        }
        _ordenService.Add(orden);
        return Ok("Orden agregada");
    }

}