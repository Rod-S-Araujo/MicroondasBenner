namespace MicroondasBenner.Models;

public class CookModels
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Alimento { get; set; }
    public decimal Tempo { get; set; }
    public int Potencia { get; set; }
    public string stringAquecimento { get; set; }
    public string instrucoes { get; set; }
    public bool Alteravel { get; set; }
}
