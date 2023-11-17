using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    class Colaborador
    {

        public virtual void CalcularSalario(double salario)
        {
            double result = salario * 0.86;
            Console.WriteLine("O desconto padrão do INSS é de " + result);
        }


            public virtual void CalcularIRRF(double salario)
        {
            double result = salario * 0.80;
            Console.WriteLine("O desconto padrão é de " + result);



        } 
    }
}


