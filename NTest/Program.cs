using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = "*";
            

            //oppgave:
            //få dette til å gå evig. ved å bruke en eller annen loop. foreach, while, for


            //loop legger til tegn
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(symbol);
                //manipulere symbolet for hver runde
                symbol = symbol + "*";
                Thread.Sleep(100);
            }
            //fjerner tegn
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(symbol);
                //manipulere symbolet for hver runde
                symbol = symbol.Remove(symbol.Length-1, 1);
                Thread.Sleep(100);
            }

            


            Console.ReadLine();
        }
    }
}
