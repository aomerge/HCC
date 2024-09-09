using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.src.model;
public class tbHccOrdenDetalle{
    [Key]
    [Column("ordet_id", TypeName = "int")]
    public int ordetId { get; set; }

    [Column("ord_id", TypeName = "int")]
    public int ordId { get; set; } // Clave foránea a la tabla Orden

    [ForeignKey("OrdId")]
    public tbHccOrdenes orden { get; set; }

    [Column("pro_id", TypeName = "int")]
    public int proId { get; set; } // Clave foránea a la tabla Producto

    [ForeignKey("ProId")]
    public tbHccProducto producto { get; set; }

    [Column("ordet_precio", TypeName = "decimal(18,2)")]
    public short ordetCantidad { get; set; }
    
    [Column("ordet_estatus", TypeName = "tinyint")]
    public byte ordetEstatus { get; set; } 
    
}