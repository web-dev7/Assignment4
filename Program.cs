using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1234";

            string res = str.ToCurrency();

            Console.WriteLine(res);
        }
    }
}
