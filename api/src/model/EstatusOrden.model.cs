using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.src.model;

[Table("Tb_HccEstatusOrden")]
public class tbHccEstatusOrden{
    [Key]
    [Column("catord_id")]
    [Required]
    public int catordId { get; set; }

    [Column("catord_nombre")]
    [Required]
    [MaxLength(50)]
    public string catordNombre { get; set; }
    
    [Column("catord_estatus")]
    [Required]
    public byte catordEstatus { get; set; }    

    public ICollection<tbHccOrdenes> Ordenes { get; set; }

    
    
}