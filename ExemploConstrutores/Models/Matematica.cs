namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Método executado.");
        }
    }
}