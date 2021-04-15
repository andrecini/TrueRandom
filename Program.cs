using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de sorteios: ");
            int qtdd = int.Parse(Console.ReadLine());
            Console.Write("Digite o número máximo: ");
            int max = int.Parse(Console.ReadLine());

            Console.Write("\nDigite ENTER para começar:\n");
            Console.ReadLine();

            Console.WriteLine("\n|\t\tDecimais\t\t|\t\tBinários\t\t|");

            TrueRandom rdm = new TrueRandom();
            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < qtdd; i++)
            {
                Console.WriteLine("|\t\t    {0}    \t\t|\t\t      {1}      \t\t|", rdm.SetNumber(max), rdm.SetBinary());
            }

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.ReadLine();

        }
    }
}
