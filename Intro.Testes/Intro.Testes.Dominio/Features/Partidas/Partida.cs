using Intro.Testes.Dominio.Features.Rodadas;
using System;
using System.Collections.Generic;

namespace Intro.Testes.Dominio.Features.Partidas
{
    public class Partida
    {
        public List<Rodada> rodadas { get; set; }
        public Random random { get; set; }

        public Partida()
        {
            random = new Random();
        }

        public int SomarRodadas()
        {
            int resultado = 0;

            foreach (var rodada in rodadas)
                resultado += rodada.ValorDaRodada;

            return resultado;
        }
    }
}
