using System;

namespace api.src.config;

public class resultadoExitoso<T> {

    public int estatus { get; set; }

    public string Mensaje { get; set; }

    public DateTime Fecha { get; set; }

    public List<T> Datos { get; set; }    

}