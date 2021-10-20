using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string temp;

            Console.Write("Introduza o primeiro número: ");
            temp = Console.ReadLine();
            a = Convert.ToInt32(temp);

            Console.Write("Introduza o segundo número: ");
            temp = Console.ReadLine();
            b = Convert.ToInt32(temp);

            Console.Write("Introduza o terceiro número: ");
            temp = Console.ReadLine();
            c = Convert.ToInt32(temp);

        if (a > b) 
        {
            if (a > c) Console.WriteLine("O maior é " + a);
            else Console.WriteLine("O maior é " + c);
        }
        else
        {
            if(b > c) Console.WriteLine("O maior é " + b);
            else Console.WriteLine("O maior é " + c);
        }
        }
    }
}
