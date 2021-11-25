using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Tatiana");
            string myString = "Hello";
            string myNextString = "World";

            string a = "a";
            string b = "b";
            string c = "c";

            string random = "B";


            int resultLeft = string.Compare(a, b);
            int resultRight = string.Compare(c, b);
            int resultEqual = string.Compare(random, b, false);

            //Concat
            myString = myString + "world";
            string helloWorld = myString + "" + myNextString;

            Stopwatch stopWatch = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                myString += i;
            }

            stopWatch.Stop();
            Console.WriteLine("For String" + stopWatch.Elapsed);

            Stopwatch stopWatch1 = Stopwatch.StartNew();

            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
            }

            stopWatch1.Stop();
            Console.WriteLine("For StringBuilder" + stopWatch1.Elapsed);
        }
    }
}
