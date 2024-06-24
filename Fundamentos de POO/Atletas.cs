using System;

public abstract class Atleta 

{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    private abstract void hacerDeporte();
}


public class Nadador : Atleta
{
    public double MejorTiempo { get; set; }
    private override void hacerDeporte()
	{
        Console.WriteLine($"{Nombre} está entrenando para correr.");  
}
}

public class Nadador : Atleta
{
    public string EstiloFavorito { get; set; }

    // Implementación del método abstracto (Polimorfismo - Sobreescritura)
    public override void Entrenar()
    {
        Console.WriteLine($"{Nombre} está entrenando para nadar.");
    }
}

