using System;

namespace FundamentosDePOO;

internal class Program
{
    public static void Main(string[] args)
    {
        
        Atleta corredor = new Corredor { Nombre = "Usain Bolt", Edad = 37, MejorTiempo = 9.69 };
        Atleta nadador = new Nadador { Nombre = "Michael Phelps", Edad = 38, EstiloFavorito = "Mariposa" };

        corredor.Entrenar(); 
        nadador.Entrenar(); 

        
        corredor.Competir(); 
        nadador.Competir(); 

    
        Console.WriteLine($"{corredor.Nombre} tiene un mejor tiempo de {((Corredor)corredor).MejorTiempo} segundos.");
        Console.WriteLine($"{nadador.Nombre} prefiere nadar en estilo {((Nadador)nadador).EstiloFavorito}.");
    }
}
