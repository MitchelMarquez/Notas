using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Notas.Models
{
    public  class Nota
  {

    [Key]
    [DatabaseGenerated( DatabaseGeneratedOption.Identity )]
    public int ID { get; set; }

    [Required]
    public string Titulo { get; set; }

    [Required]
    public string Cuerpo { get; set; }
    
    [Required]
    public Usuario  Creador { get; set; }
   }
}