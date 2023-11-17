using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
     class Poupanca : Conta
    {
        public override void CalcularImposto(double imposto)
        {
            double result = imposto * 0.6;
            Console.WriteLine("O desconto padrão e de " + result);
        }

    }
}
