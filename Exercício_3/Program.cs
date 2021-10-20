using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, p;
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario <= 2800)
            {
                p = 20;
            }
            else if (salario <= 7000)
            {
                p = 15;
            }
            else if (salario <= 15000)
            {
                p = 10;
            }

            else
            {
                p = 5;
            }

            Console.WriteLine("salário original" + salario);
            Console.WriteLine("porcentagem" + p);
            p = p / 100;
            double aumento = p * salario;
            double novo = salario + aumento;
            Console.WriteLine("aumento" + aumento);
            Console.WriteLine("novo salario" + novo);
        }
    }
}
