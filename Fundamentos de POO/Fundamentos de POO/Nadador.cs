namespace FundamentosDePOO;


public class Nadador : Atleta
{
    public string EstiloFavorito { get; set; }


    public override void Entrenar()
    {
        Console.WriteLine($"{Nombre} está entrenando para nadar.");
    }


    public override void Competir()
    {
        Console.WriteLine($"{Nombre} está nadando en una competencia.");
    }

}