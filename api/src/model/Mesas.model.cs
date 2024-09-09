using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.src.model;

[Table("Tb_HccMesas")]
public class tb_HccMesas
{
    [Key]
    [Column("mes_id", TypeName = "int")]
    [Required]        
    public int mesId { get; set; }

    [Column("mes_nombre", TypeName = "varchar(50)")]
    [Required]
    public string messNombre { get; set; }

    [Column("mes_estatus", TypeName = "tinyint")]
    [Required]
    public byte mesEstatus { get; set; }   

    public ICollection<tbHccOrdenes> Ordenes { get; set; } 

}
