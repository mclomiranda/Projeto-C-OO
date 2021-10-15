using Byte_Bank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Bank2.Sistema
{
    public class SistemaInterno
    {
        public bool Logar (IAutenticavel usuario, string senha)
        {
           bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Login autorizado");
                return true;
              
            }
            else
            {
                Console.WriteLine("Usuário ou senha errados");
                return false;
            }


        
        }


    }
}
