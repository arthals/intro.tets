using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Testes.Dominio.Features.Dados
{
    public class Dado
    {
        public int NumeroDeLados { get; set; }

        public int JogarDado(Random random) {
            return random.Next(1, NumeroDeLados + 1);
        }

    }
}
