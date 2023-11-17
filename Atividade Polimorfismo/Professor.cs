using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    internal class Professor : Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.82;
            Console.WriteLine("O desconto padrão para professores é de " + result);
        }
    }
}
