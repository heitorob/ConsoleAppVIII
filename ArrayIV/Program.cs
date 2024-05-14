using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de números: ");
            int range = int.Parse(Console.ReadLine());

            int[] num = new int[range];
            int menor = int.MaxValue;
            int maior = int.MinValue;

            for (int i = 0; i < range; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número : ");
                num[i] = int.Parse(Console.ReadLine());

                if (num[i] <= menor) { menor = num[i]; }
                if (num[i] >= maior) { maior = num[i]; }
            }

            Console.Write("---------------\nNúmeros:");
            for (int i = 0; i < range; i++)
            {
                Console.Write(" " + num[i] + " ");

            }

            Console.WriteLine("\nMaior:" + maior + "\nMenor:" + menor);

            Console.ReadKey();
        }
    }
}
