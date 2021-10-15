using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Bank2.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();

        public Funcionario(string cpf,double salario) 
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionario++;
            Console.WriteLine("Construindo um Funcionário");
        }

     

       
    }
}
