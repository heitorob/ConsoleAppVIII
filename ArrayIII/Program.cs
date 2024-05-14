using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];

            int obesos = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite o peso (em Kg): ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite a altura (em m): ");
                altura[i] = double.Parse(Console.ReadLine());

                Console.Clear();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome: " + nome[i] + "\nPeso: " + peso[i].ToString("F2")
                                   + " Kg\nAltura: " + altura[i].ToString("F2")
                                   + " m\nIMC: " + (peso[i] / (altura[i] * altura[i])).ToString("F3"));

                if ((peso[i] / (altura[i] * altura[i])) > 40)
                {
                    Console.WriteLine("Obesidade Grau III\n-----------");
                    obesos++;
                }
                else if ((peso[i] / (altura[i] * altura[i])) > 35)
                {
                    Console.WriteLine("Obesidade Grau II\n-----------");
                    obesos++;
                }
                else if ((peso[i] / (altura[i] * altura[i])) > 30)
                {
                    Console.WriteLine("Obesidade Grau I\n-----------");
                    obesos++;
                }
                else if ((peso[i] / (altura[i] * altura[i])) > 25)
                {
                    Console.WriteLine("Acima do Peso\n-----------");
                }
                else if ((peso[i] / (altura[i] * altura[i])) > 18.5)
                {
                    Console.WriteLine("Peso Normal\n-----------");
                }
                else if ((peso[i] / (altura[i] * altura[i])) > 17)
                {
                    Console.WriteLine("Abaixo do Peso\n-----------");
                }
                else
                {
                    Console.WriteLine("Muito Abaixo do Peso\n-----------");
                }
            }

            Console.Write(obesos + " de 5 estão com algum grau de obesidade.");
            Console.ReadKey();
        }
    }
}
