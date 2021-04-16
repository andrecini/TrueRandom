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

            Console.WriteLine("\n|\t   Decimais TrueRandom   \t|");

            Random rdm = new Random();
            TrueRandom trdm = new TrueRandom();
            Stopwatch sw = new Stopwatch();

            #region Iterações Random
            sw.Start();

            for (int i = 0; i < qtdd; i++)
            {
                Console.WriteLine("|\t\t    {0}    \t\t|", trdm.SetInteger(max));
            }

            sw.Stop();
            #endregion

            Console.WriteLine(sw.ElapsedMilliseconds);

            #region Iterações Random
            ///Console.WriteLine("\n|\t    Decimais Random\t\t|");
            ///
            ///sw.Start();
            ///
            ///for (int i = 0; i < qtdd; i++)
            ///{
            ///    Console.WriteLine("|\t\t    {0}    \t\t|", rdm.Next(max));
            ///}
            ///
            ///sw.Stop();
            ///
            ///Console.WriteLine(sw.ElapsedMilliseconds);
            #endregion

            Console.ReadLine();

        }
    }
}
