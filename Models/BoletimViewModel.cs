namespace Boletim_Notas.Models;

public class BoletimViewModel
{
    public List<BoletimItem> Itens { get; set; } = new List<BoletimItem>();

    public double MediaGeral => Itens.Count == 0 ? 0 : Itens.Average(item => item.Nota);
}
