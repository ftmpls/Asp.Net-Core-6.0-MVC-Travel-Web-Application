using System.ComponentModel.DataAnnotations;
namespace BitirmeProjesi.Models
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? message { get; set; }
        public string? KisiResimUrl { get; set; }
    }
}
