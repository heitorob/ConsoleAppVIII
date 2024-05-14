using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = { "Emmerson", "Ricardo", "Oscar" };

            Console.Write("Insira o ID de um nome (0 a 2): ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome selecionado: " + nome[id]);
            Console.ReadKey();
        }
    }
}
