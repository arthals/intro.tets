using Intro.Testes.Dominio.Features.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Testes.Dominio.Features.Rodadas
{
    public class Rodada
    {
        public List<Dado> dados { get; set; }
        public int ValorDaRodada { get; set; }

        public Rodada()
        {
            dados = new List<Dado>();
        }

        public void JogarDados(Random random) {
            int resultado = 0;
            foreach (var dado in dados)
            {
                resultado += dado.JogarDado(random);
            }
            ValorDaRodada = resultado;
        }

        public bool ValidarRodada()
        {
            int resultado = 0;
            foreach (var dado in dados)
                resultado += dado.NumeroDeLados;

            return resultado < ValorDaRodada; 
        }
    }
}
