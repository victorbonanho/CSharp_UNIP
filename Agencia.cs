using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Csharp
{
    class Agencia
    {
        public int num { get; set; }
        public Endereco end;

        public Agencia()
        {
            num = 0;
            end = new Endereco();
            end.Cep = 10;
        }
    }
}
