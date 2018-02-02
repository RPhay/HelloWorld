using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using QuoteMan;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Quotes myQuotes = new Quotes();
            for (int i = 1; i < 25; i++)
            {
                Console.WriteLine(myQuotes.PrintRandomQuote());
            }
            Thread.Sleep(5000);
        }
    }
}
