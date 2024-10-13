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

            while (true)
            {

                //loop legger til tegn
                for (int starten = 0; starten < 9; starten++)
                {
                    Console.WriteLine(symbol);
                    //manipulere symbolet for hver runde
                    symbol = symbol + "*";
                    Thread.Sleep(100);
                }

                //fjerner tegn
                for (int slutten = 0; slutten < 10; slutten++)
                {
                    Console.WriteLine(symbol);
                    //manipulere symbolet for hver runde
                    if (symbol.Length > 0)
                    {
                        symbol = symbol.Remove(symbol.Length - 1, 1);
                    }
                    Thread.Sleep(100);
                }
            }
        }
    }
}
