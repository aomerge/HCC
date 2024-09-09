using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.src.model;

[Table("Tb_Hcc_Almacen")]
public class tbHccAlmacen{
    [Key]
    [Column("alm_id" ,TypeName = "int")]
    public int almId { get; set; }

    [Column("alm_cantidad",TypeName = "varchar(50)")]
    public int almCantidad { get; set; }

    [Column("alm_fecha_creacion",TypeName = "datetime")]
    public DateTime almFechaActualizacion { get; set; }

    [Column("alm_estatus",TypeName = "byte")]
    public byte almEstatus { get; set; }

}