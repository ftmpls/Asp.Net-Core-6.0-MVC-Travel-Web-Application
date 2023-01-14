using System.ComponentModel.DataAnnotations;
namespace BitirmeProjesi.Models
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string? HakkimizdaSayfaYazisi { get; set; }
        public string? AcenteIsim { get; set; }
        public string? AcenteResimUrl{ get; set; }
    }
}
