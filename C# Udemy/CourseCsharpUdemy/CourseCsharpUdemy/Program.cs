using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {pessoa1.nome}");
            Console.WriteLine($"Idade: {pessoa1.idade}");

            Console.WriteLine("Dados da segunda pessoa:");

            Console.WriteLine($"Nome: {pessoa2.nome}");
            Console.WriteLine($"Idade: {pessoa2.idade}");

            if(pessoa2.idade > pessoa1.idade)
            {
                Console.WriteLine("Pessoa mais velha: "+ pessoa2.nome);
            }else
                Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);


            Console.ReadLine();

        }
    }
}
