using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente;

namespace ConsoleApp
{
        internal class Main
        {
            static void Main(string[] args)
            {
                Cliente cliente = new Cliente();
                cliente.id = 10;
                cliente.nome = "Antonio";
                cliente.email = "antoniolps218@gmail.com";
                cliente.setBairro() = "torre";


            }
        }
}