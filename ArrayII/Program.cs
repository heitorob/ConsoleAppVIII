using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março",
                               "Abril", "Maio", "Junho", "Julho",
                               "Agosto", "Setembro", "Outubro",
                               "Novembro", "Dezembro" };

            Console.Write("Digite o número do mês: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write(meses[num - 1]);
            Console.ReadKey();
        }
    }
}
