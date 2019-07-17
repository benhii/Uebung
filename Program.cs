using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1


{
    class Program
    {
        static void Main(string[] args)
        {


            int a=2;
            int b=3;
            int c;
            c = hilfe.addiere(a,b);
            int d;
            d = hilfe.exp1(a, b);
            int e;
            e = hilfe.exp1(a, b);
            int f;
            f = hilfe.exp3(a, b);
            int g;
            g = hilfe.rek(a, b);

            Console.WriteLine(g);
            Console.WriteLine(f);
            Console.WriteLine(e);
            Console.WriteLine(c);
            Console.WriteLine(d);
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
