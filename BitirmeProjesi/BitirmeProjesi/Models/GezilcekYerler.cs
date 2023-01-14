using System.ComponentModel.DataAnnotations;

namespace BitirmeProjesi.Models
{
    public class GezilcekYerler
    {
        [Key]
        public int ID { get; set; }
        public string? AnaBaslik { get; set; }
        public  string? Aciklama { get; set; }
        
        public string ? ResimUrl { get; set; }
        public int TurID { get; set; }
        public virtual Turlar? Turlar { get; set; }    
    }
}
