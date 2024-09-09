using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace api.src.model;

[Table("Tb_HccOrdenes")]
public class tbHccOrdenes
{
    [Key]
    [Column("ord_id", TypeName = "int")]
    public int ordId { get; set; }
    
    [Column("mes_id", TypeName = "int")]
    public int mesId { get; set; }

    [ForeignKey("mesId")]
    public tb_HccMesas Mesa { get; set; }

    [Column("catord_id", TypeName = "int")]
    public int catordId { get; set; }

    [ForeignKey("catordId")]
    public tbHccEstatusOrden EstatusOrden { get; set; }

    [Column("ord_fecha_inicio", TypeName = "datetime")]
    public DateTime ordFechaInicio { get; set; }

    [Column("ord_estatus", TypeName = "tinyint")]
    public byte ordEstatus { get; set; }

    public ICollection<tbHccOrdenDetalle> DetallesOrden { get; set; }



}
