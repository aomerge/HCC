using System;
using api.src.abstraction;
using api.src.model;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace api.src.services;

public class mesasServices: IMesas
{
    private readonly AppDbContext _context;

    public mesasServices(AppDbContext context)
    {
        _context = context;
    }

    public List<int> obtenerMesasDisponibles()
    {
        var mesas = _context.Mesas.Where(mesas => !mesas.Ordenes.Any())
        .Select(mesas => new{
            mesas.mesId,
            mesas.messNombre
        }).ToList();
        
        return new List<int> { mesas.Count()};
    }
}