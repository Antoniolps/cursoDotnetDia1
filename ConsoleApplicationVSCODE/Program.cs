using System;

namespace ConsoleApplicationVSCODE
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidato candidato1 = new Candidato(44, "Antonio");
            Candidato candidato2 = new Candidato(69, "Pita");
            int votosNulos = 0;

            for(int i = 0; i < 10; i++){
                Console.WriteLine($"Vote em um candidato: {candidato1.getNumero()} ({candidato1.getNome()}) - {candidato2.getNumero()} ({candidato2.getNome()})");
                int voto = Convert.ToInt32(Console.ReadLine());

                if (voto.Equals(candidato1.getNumero()))
                {
                    candidato1.setVotos(candidato1.getVotos() + 1);
                }
                else if(voto.Equals(candidato2.getNumero()))
                {
                    candidato2.setVotos(candidato2.getVotos() + 1);
                }
                else{
                    votosNulos++;
                }
            }
            Console.WriteLine($"O candidato {candidato1.getNumero()} ({candidato1.getNome()}) teve {candidato1.getVotos()} e o candidato {candidato2.getNumero()} ({candidato2.getNome()}) teve {candidato2.getVotos()} tiveram {votosNulos} votos nulos.");
        }
    }
}
