using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace Notas.Models
{

    public class Usuario  
  {
    [Key]
    public string Mail { get;set; } 

    [Required]
    public String Nombre { get;set; }

    public List<Nota> Notas { get;set; }
  }
}