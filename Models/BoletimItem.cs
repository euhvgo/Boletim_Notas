namespace Boletim_Notas.Models;

public class BoletimItem
{
    public string Disciplina { get; set; } = string.Empty;
    public double Nota { get; set; }

    public string Status => Nota >= 6.0 ? "Aprovado" : "Reprovado";

    public string EstiloStatus => Nota >= 6.0
        ? "background-color: #96eaaa !important; color: #155724 !important; font-weight: bold;"
        : "background-color: #f499a1 !important; color: #721c24 !important; font-weight: bold;";

    public string Classificacao => Nota switch
    {
        >= 9.0 => "A",
        >= 7.0 => "B",
        >= 5.0 => "C",
        _ => "D"
    };
}
