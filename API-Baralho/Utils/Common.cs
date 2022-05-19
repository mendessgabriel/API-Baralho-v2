namespace API_Baralho.Utils
{
    public class Common
    {
        public string SetNaipe(int naipeRandom)
        {
            if (naipeRandom == 0) return "paus";
            else if (naipeRandom == 1) return "copas";
            else if (naipeRandom == 2) return "espadas";
            else return "ouros";
        }
    }
}
