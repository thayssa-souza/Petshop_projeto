using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_projeto
{
    public class DadosCadastro
    {
        //se estivesse private, não iria herdar; precisa estar public cada propriedade
        public Guid Codigo { get; private set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
    }
}
