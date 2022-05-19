namespace API_Baralho.Model
{
    public class Carta
    {
        public string Numero { get; set; }
        public string Naipe { get; set; }
        public int ValorCarta { get; set; }

        public Carta(string numero, string naipe, int valorCarta)
        {
            Numero = numero;
            Naipe = naipe;
            ValorCarta = valorCarta;
        }

        public string GetNumber()
        {
            return Numero;
        }

        public string GetNaipe()
        {
            return Naipe;
        }

        public int GetCardValue()
        {
            return ValorCarta;
        }
    }
}
