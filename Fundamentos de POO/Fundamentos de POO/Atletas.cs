namespace FundamentosDePOO;

    public abstract class Atleta
    {
        
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public abstract void Entrenar();

        public abstract void Competir();
        
    }

