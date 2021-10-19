using System;

namespace lista01ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, media;
            string dado;

            Console.Write("Digite a primeira nota: ");
            dado = Console.ReadLine();
            nota1 = Convert.ToDouble(dado);

            Console.Write("Digite a segunda nota: ");
            dado = Console.ReadLine();
            nota2 = Convert.ToDouble(dado);

            media = (nota1 + nota2) / 2;

            if (media == 10)
            {
                Console.WriteLine("Aprovado com Distinção");
            }
            else if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }



        }
    }
}
