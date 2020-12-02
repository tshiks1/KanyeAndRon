using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            for(int x = 1; x >=5; ++x)
            {
                //Console.WriteLine($"{QuoteGenerator.KanyeQuote} ");
                //
                //and {QuoteGenerator.RonQuote()}");
            }
        }
    }
}
