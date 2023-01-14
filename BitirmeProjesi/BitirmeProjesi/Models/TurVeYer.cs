using System.ComponentModel.DataAnnotations;
namespace BitirmeProjesi.Models
{
    public class TurVeYer
    {
        [Key]
        public IEnumerable<Turlar>? Deger1 { get; set; }
        public IEnumerable<GezilcekYerler>? Deger2 { get; set; }
    }
}
