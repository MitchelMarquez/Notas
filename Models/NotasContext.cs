using Microsoft.EntityFrameworkCore;
using System.Colecctions.Generic;
namespace Notas.Models
{
    
    puplic class NotasContext : Dbcontext
    {

  public NotasContext(DbcontextOptions<NotasContext> Options)
  :base(Options)
{

 }
  
  public DBSet<Nota> Nota {get;set;}
  public DBSet<Usuario> Usuario {get;set;}

 }
 
}