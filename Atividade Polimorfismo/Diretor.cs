using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    class Diretor : Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.77;
            Console.WriteLine("O desconto padrão para diretores é de " + result);   
        }
    }
}
