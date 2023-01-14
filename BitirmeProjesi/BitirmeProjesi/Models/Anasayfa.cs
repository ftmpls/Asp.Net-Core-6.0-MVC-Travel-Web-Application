using System.ComponentModel.DataAnnotations;
namespace BitirmeProjesi.Models;

public class Anasayfa
{
    [Key]
    public int ID { get; set; }
    public string? GoTourResim { get; set; }

    public string? MusteriResmiUrl { get; set; }
    public string? MusteriYorum { get; set; }

    public string? MusteriAd { get; set; }
}
