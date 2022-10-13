using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
        public class Cliente
        {
            private int Id {get; set; }
            private string Nome{get; set;}
            private string Cpf{get; set;}
            private string Email{get; set;}
            private string Logradouro{get; set;}
            private string Bairro{get; set;}
        }
        public Cliente(int id, string nome, string CPF, string email, string logradouro, string bairro)
        {
            Id = id;
            Nome = nome;
            Cpf = CPF;
            Email = email;
            Logradouro = logradouro;
            Bairro = bairro;
        }

        public Cliente()
        {
            
        }
        
        public void setBairro(String bairro){
            Bairro = bairro;
        }
        public string getBairro(){
            return bairro;
        }
        
}