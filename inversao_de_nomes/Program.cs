using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inversao_de_nomes
{
    internal class Program
    {
        //declaraçao dos nomes struct
        #region 
        struct nomes
        {
            public string nome1;
            public string nome2;
            public string nome3;
            public string nome4;
        }
        #endregion
        static void Main(string[] args)
        {
            nomes nomes_usuario = new nomes(); // entrada de dados pelo usuario para o struct

        // local da entrada
        Console.WriteLine("Ola, bem vindo a programa inversao da ordem dos nomes.");
            Console.WriteLine("Digite o primeiro nome!");
            nomes_usuario.nome1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome!");
            nomes_usuario.nome2 = Console.ReadLine();
            Console.WriteLine("Digite o terceiro nome!");
            nomes_usuario.nome3 = Console.ReadLine();
            Console.WriteLine("Digite o quarto nome!");
            nomes_usuario.nome4 = Console.ReadLine();

            /*
            local da inversao dos nomes, a sequencia dos nomes da inversao sera
            auxilia = nome1, nome1 = nome4, nome2 = nome3, nome4 = nome2, nome3 = auxiliar  
            */

            string auxiliar = nomes_usuario.nome1;
            nomes_usuario.nome1 = nomes_usuario.nome4;
            nomes_usuario.nome4 = nomes_usuario.nome3;
            nomes_usuario.nome3 = nomes_usuario.nome2;
            nomes_usuario.nome2 = auxiliar;

            // exibiçao do resultado

            Console.WriteLine("A exibiçao da inversao do resultado sera exibida logo abaixo!");
            Console.WriteLine(nomes_usuario.nome1);
            Console.WriteLine(nomes_usuario.nome4);
            Console.WriteLine(nomes_usuario.nome3);
            Console.WriteLine(nomes_usuario.nome2
                );


            Console.ReadKey();
        }
    }
}
