using System.ComponentModel.DataAnnotations;
namespace BitirmeProjesi.Models
{
    public class Turlar
    {
        [Key]
        public int ID { get; set; }
        public string? UlkeIsim { get; set; }
        public string? SehirIsim { get; set; }
        public string? UlkeResimUrl { get; set; }
        public string? TurKacGun { get; set; }
        public string? TurFiyat { get; set; }
       public ICollection<GezilcekYerler>? GezilcekYerlers { get; set; }    
    
    }
}
