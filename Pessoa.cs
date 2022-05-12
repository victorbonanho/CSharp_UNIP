using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Csharp
{
    class Pessoa
    {
        public string nome;
        public Telefone tel1, tel2;
        public Endereco end;
        public Conta conta;

        public Pessoa()
        {
            tel1 = new Telefone();
            tel2 = new Telefone();
            end = new Endereco();
            conta = new Conta();
        }
    }
}
