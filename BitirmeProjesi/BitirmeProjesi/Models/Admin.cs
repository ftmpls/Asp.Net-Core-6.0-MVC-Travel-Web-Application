using System.ComponentModel.DataAnnotations;

namespace BitirmeProjesi.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; } 
        public string? Kullanici { get; set; }   
        public string? Sifre { get; set; }  
             
    }
}
