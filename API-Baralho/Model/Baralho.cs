using System.Collections.Generic;
using System.Linq;
using API_Baralho.Utils;

namespace API_Baralho.Model
{
    public class Baralho
    {
        public List<Carta> Cartas { get; set; }

        public Baralho() { }
        public Baralho(List<Carta> cartasBaralho) {
            Cartas = cartasBaralho;
        }

        public void SetBaralhoBlackJack()
        {
            Common common = new();
            List<Carta> cartas = new();
            for (var i = 0; i < 4; i++)
            {
                string naipe = common.SetNaipe(i);
                for (var l = 1; l < 14; l++)
                {
                    Carta novacarta;
                    if (l == 1) novacarta = new Carta("A", naipe, 1);
                    else if (l == 11) novacarta = new Carta("J", naipe, 10);
                    else if (l == 12) novacarta = new Carta("Q", naipe, 10);
                    else if (l == 13) novacarta = new Carta("K", naipe, 10);
                    else novacarta = new Carta(l.ToString(), naipe, l);
                    cartas.Add(novacarta);
                }
            }
            Cartas = cartas;
        }

        public void SetBaralhoTrucoClean()
        {
            Common common = new();
            List<Carta> cartas = new();
            for (var i = 0; i < 4; i++)
            {
                string naipe = common.SetNaipe(i);
                for (var l = 1; l < 7; l++)
                {
                    Carta novacarta;
                    if (l == 1) novacarta = new Carta("A", naipe, 4);
                    else if (l == 2) novacarta = new Carta("2", naipe, 5);
                    else if (l == 3) novacarta = new Carta("3", naipe, 6);
                    else if (l == 4) novacarta = new Carta("J", naipe, 2);
                    else if (l == 5) novacarta = new Carta("Q", naipe, 1);
                    else if (l == 6) novacarta = new Carta("K", naipe, 3);
                    else novacarta = new Carta(l.ToString(), naipe, l);
                    cartas.Add(novacarta);
                }
            }
            Cartas = cartas;
        }

        public void SetBaralhoTrucoDirty()
        {
            Common common = new();
            List<Carta> cartas = new();
            for (var i = 0; i < 4; i++)
            {
                string naipe = common.SetNaipe(i);
                for (var l = 1; l < 11; l++)
                {
                    Carta novacarta;
                    if (l == 1) novacarta = new Carta("A", naipe, 8);
                    else if (l == 2) novacarta = new Carta("2", naipe, 9);
                    else if (l == 3) novacarta = new Carta("3", naipe, 10);
                    else if (l == 4) novacarta = new Carta("4", naipe, 1);
                    else if (l == 5) novacarta = new Carta("5", naipe, 2);
                    else if (l == 6) novacarta = new Carta("6", naipe, 3);
                    else if (l == 7) novacarta = new Carta("7", naipe, 4);
                    else if (l == 8) novacarta = new Carta("Q", naipe, 5);
                    else if (l == 9) novacarta = new Carta("J", naipe, 6);
                    else if (l == 10) novacarta = new Carta("K", naipe, 7);
                    else novacarta = new Carta(l.ToString(), naipe, l);
                    cartas.Add(novacarta);
                }
            }
            Cartas = cartas;
        }

        public IEnumerable<Carta> GetBaralhoByNaipe(string naipe)
        {
            if (Cartas.Count == 0 || naipe.Length == 0) return null;
            IEnumerable<Carta> cartas = Cartas.Where(carta => carta.Naipe == naipe);
            return cartas;
        }
    }
}
