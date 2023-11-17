using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    class Conta
    {
        public int agencia;
        public int conta;
        public string NomeTitular;

        public virtual void CalcularImposto(double imposto)
        {
            double result = imposto * 0.4;
            Console.WriteLine("O desconto padrão e de " + result);
        }
    }
}
