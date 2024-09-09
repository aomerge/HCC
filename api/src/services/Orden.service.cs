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
}