namespace Pensionato_Exercicio_Vetores
{
    internal class Reserva
    {
        public int NumeroQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return NumeroQuarto + ": " + Nome + ", " + Email;
        }
    }
}
