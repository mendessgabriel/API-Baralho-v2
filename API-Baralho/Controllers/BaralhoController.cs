using Microsoft.AspNetCore.Mvc;
using API_Baralho.Model;
using System.Collections.Generic;

namespace API_Baralho.Controllers
{
    [ApiController]
    [Route("/BaralhoBlackjack")]
    public class BaralhoBlackjack
    {
        [HttpGet]
        public List<Carta> Get()
        {
            Baralho baralho = new();
            baralho.SetBaralhoBlackJack();
            return baralho.Cartas;
        }
    }

    [ApiController]
    [Route("/BaralhoTrucoLimpo")]
    public class BaralhoTrucoLimpo
    {
        [HttpGet]
        public List<Carta> Get()
        {
            Baralho baralho = new();
            baralho.SetBaralhoTrucoClean();
            return baralho.Cartas;
        }
    }

    [ApiController]
    [Route("/BaralhoTrucoSujo")]
    public class BaralhoTrucoSujo
    {
        [HttpGet]
        public List<Carta> Get()
        {
            Baralho baralho = new();
            baralho.SetBaralhoTrucoDirty();
            return baralho.Cartas;
        }
    }


    [ApiController]
    [Route("/BaralhoTrucoLimpoPorNaipe")]
    public class BaralhoTrucoLimpoPorNaipe
    {
        [HttpGet]
        public IEnumerable<Carta> Get(string naipe)
        {
            Baralho baralho = new();
            baralho.SetBaralhoTrucoClean();
            return baralho.GetBaralhoByNaipe(naipe);
        }
    }
}
