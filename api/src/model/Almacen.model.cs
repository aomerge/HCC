using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.src.model;

[Table("Tb_HccAlmacen")]
public class tbHccAlmacen{
    [Key]
    [Column("alm_id" ,TypeName = "int")]
    [Required]
    public int almId { get; set; }

    [Column("alm_cantidad",TypeName = "varchar(50)")]
    [Required]
    public int almCantidad { get; set; }
    
    [Column("alm_fecha_creacion",TypeName = "datetime")]
    [Required]
    public DateTime almFechaActualizacion { get; set; }

    [Column("alm_estatus",TypeName = "byte")]
    [Required]
    public byte almEstatus { get; set; }

    public ICollection<tbHccProducto> Productos { get; set; }

}