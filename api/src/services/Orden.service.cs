using System;
using api.src.abstraction;
using api.src.model;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace api.src.services;

public class ordenService: IOrden
{
    private readonly AppDbContext _context;

    public ordenService(AppDbContext context)
    {
        _context = context;
    }

    public void Get()
    {

    }

    public List<tbHccOrdenes> GetAll()
    {
        return _context.Ordenes.ToList();
    }

    public void insertarOrden(tbHccOrdenes orden)
    {
        _context.Ordenes.Add(orden);
        _context.SaveChanges();
    }

    public List<int> obtenerOrdenesPorMesa()
    {
        var ordenes = _context.Ordenes.Select(
            o => new 
            {
                ordId = o.ordId,
                ordMesa = o.Mesa.messNombre,
                
            }).ToList();
        
        return new List<int>{ordenes.Count()};
    }

}