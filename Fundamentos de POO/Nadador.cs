namespace FundamentosDePOO
{
    // Clase que hereda de Atleta (Herencia)
    public class Nadador : Atleta
    {
        public string EstiloFavorito { get; set; }

        // Implementación del método abstracto (Polimorfismo - Sobreescritura)
        public override void Entrenar()
        {
            Console.WriteLine($"{Nombre} está entrenando para nadar.");
        }

        // Sobrescritura del método virtual (Polimorfismo)
        public override void Competir()
        {
            Console.WriteLine($"{Nombre} está nadando en una competencia.");
        }
    }
}