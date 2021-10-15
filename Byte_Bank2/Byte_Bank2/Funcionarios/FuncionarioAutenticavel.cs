﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Bank2.Funcionarios
{               
    public abstract  class FuncionarioAutenticavel: Funcionario,IAutenticavel
    {
        public FuncionarioAutenticavel(string cpf, double salario)
        : base(cpf, salario)
        {

        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    
    
    
    }
}
