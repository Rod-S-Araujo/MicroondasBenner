using System.ComponentModel.DataAnnotations;

namespace MicroondasBenner.Data.DTOs;

public class ReadCookModelDTO
{
    public string Nome { get; set; }
    public string Alimento { get; set; }
    public decimal Tempo { get; set; }
    public int Potencia { get; set; }
    public string stringAquecimento { get; set; }
    public string instrucoes { get; set; }
    public bool Alteravel { get; set; }

}
