using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace  Notas.Models
{
    public  class Nota
  {

    // [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID {get; set;}

    // [Require]
    public string Titulo {get; set;}

    // [Require]
    public string Cuerpo {get; set;}
    
    // [Require]
    public Usuario  Creador {get; set;}
   }
}