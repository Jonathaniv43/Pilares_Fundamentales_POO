namespace FundamentosDePOO;


public class Corredor : Atleta
{
    public double MejorTiempo { get; set; }

    private void Calentar()
    {
        Console.WriteLine($"{Nombre} está calentando antes de entrenar. Correrá 100 metros");
    }


    public override void Entrenar()
    {
        Calentar();
        Console.WriteLine($"{Nombre} está entrenando para correr.");
    }


    public override void Competir()
    {
        Console.WriteLine($"{Nombre} está corriendo en una competencia.");
    }
}
