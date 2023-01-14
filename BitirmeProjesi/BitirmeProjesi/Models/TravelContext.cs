

//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace BitirmeProjesi.Models
{
    public class TravelContext:DbContext
    {
      

        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }
   
        public DbSet<Anasayfa>? Anasayfas { get; set; }
        public DbSet<Hakkimizda>? Hakkimizdas { get; set; }
        public DbSet<Iletisim>? Iletisims { get; set; }
        public DbSet<Turlar>? Turlars { get; set; }
       
        public DbSet<Admin>? Admins { get; set; }   
        public DbSet<GezilcekYerler>? GezilcekYerlers{ get; set; }
        
    }
}
