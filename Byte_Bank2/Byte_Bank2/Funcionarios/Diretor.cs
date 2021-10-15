using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Bank2.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {    
        public Diretor(string cpf,double salario) : base(cpf,salario)
        {
            Console.WriteLine("Construindo um Diretor");

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5 ;
        }
    }
}
