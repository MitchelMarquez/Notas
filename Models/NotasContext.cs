using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Notas.Models
{
    
    public class NotasContext : DbContext
    {

  public NotasContext(DbContextOptions<NotasContext> Options)
  :base(Options)
{

 }
  
  public DbSet<Nota> Nota {get;set;}
  public DbSet<Usuario> Usuario {get;set;}

 }
 
}