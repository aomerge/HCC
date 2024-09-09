using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.src.model;
public class tbHccProducto{
    [Key]
    [Column("pro_id")]
    public int proId  { get; set; }

    [Column("alm_id")]
    public int almId { get; set; }

    [ForeignKey("almId")]
    public tbHccAlmacen Almacen { get; set; }

    [Column("pro_nombre", TypeName = "varchar(50)")]
    [Required]
    public string proNombre { get; set; }

    [MaxLength(120)]
    [Column("pro_descripcion")]
    public string proDescripcion { get; set; }

    [Column("pro_precio")]
    public decimal proPrecio { get; set; }

    [Column("pro_estatus")]
    public byte proEstatus { get; set; }

     public ICollection<tbHccOrdenDetalle> DetallesOrden { get; set; }
    
}