using System;

namespace ConsoleApplicationVSCODE
{
    public class Candidato
    {
        private int Numero { get; set; }

        private string Nome { get; set; }

        private int Votos { get; set; }

        public Candidato(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public string getNome(){
            return Nome;
        }

        public void setNome(string nome){
            Nome = nome;
        }

        public int getNumero(){
            return Numero;
        }

        public void setNumero(int numero){
            Numero = numero;
        }

        public int getVotos(){
            return Votos;
        }

        public void setVotos(int votos){
            Votos = votos;
        }
    }

}