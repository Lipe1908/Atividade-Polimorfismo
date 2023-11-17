using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    class Coordenador : Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.89;
            Console.WriteLine("O desconto padrão para coordenadores é de " + result);
        }
    }
}
