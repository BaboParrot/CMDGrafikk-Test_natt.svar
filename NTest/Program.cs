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
                for (int legg_til = 0; legg_til < 9; legg_til++)
                {
                    Console.WriteLine(symbol);
                    //manipulere symbolet for hver runde
                    symbol = symbol + "*";
                    Thread.Sleep(100);
                }

                //fjerner tegn
                for (int fjern = 0; fjern < 10; fjern++)
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
