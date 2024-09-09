using Microsoft.AspNetCore.Mvc;
using api.src.services;
using api.src.abstraction;
using api.src.model;
using api.src.config;
namespace api.src.controller;

[ApiController]
[Route("api/[controller]")]
public class mesasController : ControllerBase
{
    private readonly IMesas _mesasService;

    public mesasController(IMesas mesasService)
    {
        _mesasService = mesasService;
    }    

    [HttpGet("obtenerMesasDisponibles")]    
    public IActionResult Get()
    {
        var mesas = _mesasService.obtenerMesasDisponibles();
        var respuesta = new resultadoExitoso<int>
            {
                estatus = 200,
                Mensaje = "Peticion exitosa",
                Fecha = DateTime.Now,
                Datos = mesas,
                codigo = 1
            };        

        return Ok(respuesta);
    }
}