using System.ComponentModel.DataAnnotations;

namespace MicroondasBenner.Data.DTOs;

public class CreateCookModelDTO
{
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Alimento { get; set; }
    [Required]
    public decimal Tempo { get; set; }
    [Required]
    public int Potencia { get; set; }
    public string stringAquecimento { get; set; }
    [Required]
    public string instrucoes { get; set; }
}
