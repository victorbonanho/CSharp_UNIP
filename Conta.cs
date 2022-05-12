using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Csharp
{
    class Conta
    {
        public double saldo { get; }
        public Agencia Ag;
        
        public Conta()
        {
            Ag = new Agencia();
        }
    }
}
